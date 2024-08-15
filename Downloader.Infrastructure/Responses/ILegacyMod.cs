namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Legacy mod was used  in the previous version of the mod downloader.
/// The mods are stored in a json file on GitHub.
/// </summary>
public interface ILegacyMod : IBaseMod
{
    string Domain { get; }
    string FileName { get; }
    string State { get; }
    IEnumerable<string> DependsOn { get; }
}