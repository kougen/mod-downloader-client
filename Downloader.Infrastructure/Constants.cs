namespace Downloader.Infrastructure;

public static class Constants
{
    public static readonly List<string> LegacyModGroups =
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

    public const string LegacyModsPath = "https://raw.githubusercontent.com/kougen/minecraft-mods/main/mod-downloader/config/mods";

    public static IEnumerable<string> GetLegacyModUrls()
    {
        return LegacyModGroups.Select(group => $"{LegacyModsPath}/{group}.json");
    }
}