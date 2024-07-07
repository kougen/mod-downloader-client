namespace Downloader.Infrastructure;

public static class Constants
{
    private static readonly List<string> LegacyModGroups =
    [
        "abnormals",
        "addons",
        "base",
        "client",
        "dimensions",
        "essentials",
        "food",
        "ftb",
        "mapgen",
        "mobs",
        "perf",
        "server",
        "thermal",
        "util"
    ];
    private const string LegacyModsPath = "https://raw.githubusercontent.com/kougen/minecraft-mods/main/mod-downloader/config/";

    public static IEnumerable<string> GetLegacyModUrls()
    {
        return LegacyModGroups.Select(group => $"{LegacyModsPath}/mods/{group}.json");
    }
    
    public static string GetLegacyModPackUrl()
    {
        return $"{LegacyModsPath}/packs.json";
    }
}