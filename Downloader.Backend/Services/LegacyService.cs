using System.Text.Json;
using Downloader.Backend.Responses;
using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;
using Newtonsoft.Json;

namespace Downloader.Backend.Services;

public class LegacyService : ILegacyService
{
    public async Task<IEnumerable<IBaseMod>> GetModsAsync(IEnumerable<string> urls)
    {
        var result = new List<IBaseMod>();
        using var client = new HttpClient();

        foreach (var url in urls)
        {
            var mods = await GetPartialAsync<LegacyMod>(client, url);
            result.AddRange(mods.Select(mod => new BaseMod { Id = mod.Id }));
        }

        return result;
    }

    public IEnumerable<IBaseMod> GetMods(IEnumerable<string> urls)
    {
        return GetModsAsync(urls).Result;
    }

    public async Task<IEnumerable<ILegacyModPack>> GetModPacksAsync(string url)
    {
        return await GetAsync<LegacyModPack>(url);
    }

    public IEnumerable<ILegacyModPack> GetModPacks(string url)
    {
        return GetModPacksAsync(url).Result;
    }

    #region Private methods

    private async Task<IEnumerable<T>> GetAsync<T>(string url)
    {
        return await GetPartialAsync<T>(new HttpClient(), url);
    }
    
    private async Task<IEnumerable<T>> GetPartialAsync<T>(HttpClient client, string url)
    {
        var response = await client.GetAsync(url);
        if (!response.IsSuccessStatusCode)
        {
            return new List<T>();
        }

        var contentStr = await response.Content.ReadAsStringAsync();
        var content = JsonConvert.DeserializeObject<IEnumerable<T>>(contentStr);
        return content ?? new List<T>();
    }

    #endregion
}