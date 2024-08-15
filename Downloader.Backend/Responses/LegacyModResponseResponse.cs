using Downloader.Infrastructure.Responses;
using Newtonsoft.Json;

namespace Downloader.Backend.Responses;

[method: JsonConstructor]
public class LegacyModResponseResponse(string id, string domain, string filename, string state, IEnumerable<string> dependOn)
    : ILegacyModResponseResponse
{
    [JsonProperty("id")]
    public string Id { get; } = id;

    [JsonProperty("domain")]
    public string Domain { get; } = domain;

    [JsonProperty("filename")]
    public string FileName { get; } = filename;

    [JsonProperty("state")]
    public string State { get; } = state;

    [JsonProperty("depend_on")]
    public IEnumerable<string> DependsOn { get; } = dependOn;
}