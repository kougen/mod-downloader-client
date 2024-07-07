using Downloader.Infrastructure.Responses;
using Newtonsoft.Json;

namespace Downloader.Backend.Responses;

public class LegacyModPack : ILegacyModPack
{
    [JsonProperty("name")]
    public string Name { get; }
    
    [JsonProperty("display_name")]
    public string DisplayName { get; }
    
    [JsonProperty("description")]
    public string Description { get; }
    
    [JsonProperty("pack_content")]
    public IEnumerable<string> PackContent { get; }
    
    [JsonConstructor]
    public LegacyModPack(string name, string displayName, string description, IEnumerable<string> packContent)
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        PackContent = packContent;
    }
}