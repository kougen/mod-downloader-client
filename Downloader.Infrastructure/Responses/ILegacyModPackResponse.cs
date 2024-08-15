namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Interface for legacy mod packs which were used in the previous version of the mod downloader.
/// </summary>
public interface ILegacyModPackResponse
{
    string Name { get; }
    string DisplayName { get; }
    string Description { get; }
    IEnumerable<string> PackContent { get; }
}