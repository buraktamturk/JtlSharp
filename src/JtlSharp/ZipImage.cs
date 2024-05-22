using System.IO.Compression;
using Jtl.Connector.Core.Model;
using Microsoft.AspNetCore.StaticFiles;

namespace JtlSharp;

public record ZipImage : AbstractImage
{
    private static readonly FileExtensionContentTypeProvider DefaultMimeMapping = new();
    private readonly ZipArchive _archive;
    
    public ZipImage(AbstractImage img, ZipArchive archive) : base(img)
    {
        this._archive = archive;
    }
    
    public override bool CanOpen()
        => _archive.Entries.Any(a =>
            a.Name.StartsWith($"{id.host}_{relationType}.", StringComparison.InvariantCultureIgnoreCase));

    public override Stream OpenStream(out long length, out string? mimeType)
    {
        var entry = _archive.Entries.First(a =>
            a.Name.StartsWith($"{id.host}_{relationType}.", StringComparison.InvariantCultureIgnoreCase));
        length = entry.Length;

        if (!DefaultMimeMapping.TryGetContentType(Path.GetExtension(entry.Name), out mimeType))
            mimeType = null;
        
        return entry.Open();
    }
}
