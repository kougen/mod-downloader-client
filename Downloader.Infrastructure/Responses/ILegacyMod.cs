namespace Downloader.Infrastructure.Responses;

public interface ILegacyMod
{
    string Id { get; }
    string Domain { get; }
    string FileName { get; }
    string State { get; }
    IEnumerable<string> DependsOn { get; }
}