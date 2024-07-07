namespace Downloader.Infrastructure.Responses;

public interface ILegacyModPack
{
    string Name { get; }
    string DisplayName { get; }
    string Description { get; }
    IEnumerable<string> PackContent { get; }
}