namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Legacy mod was used  in the previous version of the mod downloader.
/// The mods are stored in a json file on GitHub.
/// </summary>
public interface ILegacyMod : IBaseMod
{
    string Domain { get; set; }
    string FileName { get; set; }
    string State { get; set; }
    IEnumerable<string> DependsOn { get; set; }
}