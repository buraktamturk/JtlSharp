using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace JtlSharp.Tests;

public class CodeGen(ITestOutputHelper output)
{
    [Fact]
    public async Task GenerateModels()
    {
        var codePath = Path.Join(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "src", "JtlSharp", "Model");
        
        if (!Directory.Exists(codePath))
            throw new Exception("Directory not found");
        
        await foreach (var file in GetModelFiles())
        {
            var (className, extends) = Parse(file);
            var properties = ParseProperties(file).ToList();
            
            if (className is null)
                continue;
            
            
            StringBuilder sb = new();
            sb.AppendLine("namespace Jtl.Connector.Core.Model;");
            sb.AppendLine();
            if (extends is null)
                sb.AppendLine($"public record {className}");
            else
                sb.AppendLine($"public record {className} : {extends}");
            sb.AppendLine("{");
            foreach (var (type, name, description) in properties)
            {
                if (description.Contains("@Serializer\\Exclude"))
                    continue;
                
                sb.AppendLine($"    /// <summary>");
                sb.AppendLine($"    /// {description.Replace("*", "///")}");
                sb.AppendLine($"    /// </summary>");
                sb.AppendLine($"    public {type}? {name} {{ get; init; }}");
                sb.AppendLine();
            }
            sb.AppendLine("}");
            sb.AppendLine();
            
            await File.WriteAllTextAsync(Path.Join(codePath, $"{className}.cs"), sb.ToString(), Encoding.UTF8);
        }
    }
    
    private IEnumerable<(string type, string name, string description)> ParseProperties(string phpCode)
    {
        string pattern = @"@var\s+(.*?)\W*@Serializer\\Type\(""(.*?)""\).*?@Serializer\\SerializedName\(""([^""]+)""";

        if (phpCode.LastIndexOf("public const") is { } lastIndex and not -1)
            phpCode = phpCode[lastIndex..]; 
        
        MatchCollection matches = Regex.Matches(phpCode, pattern, RegexOptions.Singleline);

        foreach (Match match in matches)
        {
            string varDescription = match.Groups[1].Value;
            string serializerType = ParseType(match.Groups[2].Value.Replace("Jtl\\Connector\\Core\\Model\\", ""));
            string serializerSerializedName = match.Groups[3].Value;

            yield return (serializerType, serializerSerializedName, varDescription);
        }
    }

    private static string ParseType(string phpType)
        => phpType switch
        {
            var s when s.StartsWith("array<") && s.Contains(',') 
                => $"IReadOnlyDictionary<{ParseType(s[6..(s.IndexOf(','))])}, {ParseType(s[(s.IndexOf(',') + 2)..^1])}>",
            var s when s.StartsWith("array<") => $"IReadOnlyCollection<{ParseType(s[6..^1])}>",
            "integer" => "int",
            "double" => "decimal",
            "boolean" => "bool",
            "DateTimeInterface" => "DateTimeOffset",
            var s => s
        };

    private (string? className, string? extends) Parse(string phpCode)
    {
        string classNamePattern = @"class\s+(\w+)\s+extends\s+(\w+)";

        var classNameMatch = Regex.Match(phpCode, classNamePattern);
        if (classNameMatch.Success)
        {
            string className = classNameMatch.Groups[1].Value;
            string extendedClassName = classNameMatch.Groups[2].Value;

            return (className, extendedClassName);
        }
        else
        {
            classNamePattern = @"class\s+(\w+)\s+";
            classNameMatch = Regex.Match(phpCode, classNamePattern);
            if (classNameMatch.Success)
            {
                string className = classNameMatch.Groups[1].Value;
                
                return (className, null);
            }
        }

        return (null, null);
    }

    private async IAsyncEnumerable<string> GetModelFiles()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetStreamAsync("https://codeload.github.com/jtl-software/connector-core/zip/refs/heads/master");
        
        using var archive = new ZipArchive(response, ZipArchiveMode.Read);
        foreach (var entry in archive.Entries)
        {
            if (!entry.FullName.StartsWith("connector-core-master/src/Model/") ||
                entry.FullName.StartsWith("connector-core-master/src/Model/Generator") ||
                !entry.FullName.EndsWith(".php")) continue;
            
            await using var stream = entry.Open();
            using var reader = new StreamReader(stream);
            yield return await reader.ReadToEndAsync();
        }
    }
}