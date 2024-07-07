using Newtonsoft.Json;

namespace Downloader.Backend.Responses;

public class LegacyMod
{
    [JsonProperty("id")]
    public string Id { get; }
    
    [JsonProperty("domain")]
    public string Domain { get; }
    
    [JsonProperty("filename")]
    public string FileName { get; }
    
    [JsonProperty("state")]
    public string State { get; }
    
    [JsonProperty("depend_on")]
    public IEnumerable<string> DependsOn { get; }
    
    [JsonConstructor]
    public LegacyMod(string id, string domain, string filename, string state, IEnumerable<string> dependOn)
    {
        Id = id;
        Domain = domain;
        FileName = filename;
        State = state;
        DependsOn = dependOn;
    }
}