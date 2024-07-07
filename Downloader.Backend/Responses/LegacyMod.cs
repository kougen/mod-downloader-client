using Downloader.Infrastructure.Responses;

namespace Downloader.Backend.Responses;

public class LegacyMod(string id, string domain, string fileName, string state, IEnumerable<string> dependsOn)
    : ILegacyMod
{
    public string Id { get; } = id;
    public string Domain { get; } = domain;
    public string FileName { get; } = fileName;
    public string State { get; } = state;
    public IEnumerable<string> DependsOn { get; } = dependsOn;
}