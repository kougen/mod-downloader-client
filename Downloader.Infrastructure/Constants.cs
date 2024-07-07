namespace Downloader.Infrastructure;

public static class Constants
{
    public static List<string> LEGACY_MOD_GROUPS =
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

    public static string LEGACY_MODS_PATH =
        "https://raw.githubusercontent.com/kougen/minecraft-mods/main/mod-downloader/config/mods";
    
    public static IEnumerable<string> GetLegacyModUrls()
    {
        return LEGACY_MOD_GROUPS.Select(group => $"{LEGACY_MODS_PATH}/{group}.json");
    }
}