using Downloader.Infrastructure.Responses;
using Newtonsoft.Json;

namespace Downloader.Backend.Responses;

[method: JsonConstructor]
public class LegacyModPackResponse(string name, string displayName, string description, IEnumerable<string> packContent)
    : ILegacyModPackResponse
{
    [JsonProperty("name")]
    public string Name { get; } = name;

    [JsonProperty("display_name")]
    public string DisplayName { get; } = displayName;

    [JsonProperty("description")]
    public string Description { get; } = description;

    [JsonProperty("pack_content")]
    public IEnumerable<string> PackContent { get; } = packContent;
}