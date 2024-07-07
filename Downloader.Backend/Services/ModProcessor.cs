using System.Text;
using Downloader.Backend.Responses;
using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;
using Newtonsoft.Json;

namespace Downloader.Backend.Services;

[method: JsonConstructor]
internal class GetModBody(IEnumerable<int> modIds)
{
    [JsonProperty("modIds")]
    public IEnumerable<int> ModIds { get; set; } = modIds;
    
    [JsonProperty("filterPcOnly")]
    public bool FilterPcOnly { get; set; } = true;
}

[method: JsonConstructor]
internal class GetModResponse(IEnumerable<ModDetails> data)
{
    [JsonProperty("data")]
    public IEnumerable<ModDetails> Data { get; set; } = data;
}

public class ModProcessor : IModProcessor
{
    private readonly HttpClient _client;
    private readonly string _apiKey;
    public ModProcessor(string apiKey)
    {
        _apiKey = apiKey;
        _client = new HttpClient();
        
        SetupClient();
    }
    
    ~ModProcessor()
    {
        _client.Dispose();
    }
    
    public IModDetails? GetModDetails(string id)
    {
        return GetModDetails(int.Parse(id));
    }

    public IModDetails? GetModDetails(int id)
    {
        var details = GetModDetails(new List<int> { id });
        return details.FirstOrDefault();
    }

    public IEnumerable<IModDetails> GetModDetails(IEnumerable<string> ids)
    {
        var intIds = ConvertIds(ids);
        return GetModDetails(intIds);
    }

    public IEnumerable<IModDetails> GetModDetails(IEnumerable<int> ids)
    {
        var url = $"{Infrastructure.Constants.CURSEFORGE_URL}/v1/mods";
        
        var jsonBody = new GetModBody(ids);
        var stringContent = new StringContent(JsonConvert.SerializeObject(jsonBody), Encoding.UTF8, "application/json");
        var response = _client.PostAsync(url, stringContent).Result;
        if (!response.IsSuccessStatusCode)
        {
            return new List<IModDetails>();
        }
        
        var content = response.Content.ReadAsStringAsync().Result;
        var mod = JsonConvert.DeserializeObject<GetModResponse>(content);
        
        if(mod == null)
        {
            return new List<IModDetails>();
        }
        
        return mod.Data;
    }

    private void SetupClient()
    {
        var headers = new Dictionary<string, string>
        {
            { "x-api-key", _apiKey }
        };
        
        foreach (var header in headers)
        {
            _client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
    }
    
    private IEnumerable<int> ConvertIds(IEnumerable<string> ids)
    {
        return ids.Select(int.Parse);
    }
}