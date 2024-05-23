using System.Collections.Frozen;
using HT.ISO;

namespace JtlSharp;

public static class IsoConverter
{
    private static readonly FrozenDictionary<string, string> _iso2to3
        = HT.ISO.ISO639.Languages
            .ToFrozenDictionary(a => a.Alpha2, a => a.Alpha3 switch
            {
                "deu" => "ger",
                var s => s
            });
    
    private static readonly FrozenDictionary<string, string> _iso3to2
        = HT.ISO.ISO639.Languages
            .ToFrozenDictionary(a => a.Alpha3 switch
            {
                "deu" => "ger",
                var s => s
            }, a => a.Alpha2);
    
    public static string? From2To3(string iso2)
        => _iso2to3.GetValueOrDefault(iso2);
    
    public static string? From3To2(string iso3)
        => _iso3to2.GetValueOrDefault(iso3);
}