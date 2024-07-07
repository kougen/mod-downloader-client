using System.Text.Json;
using Downloader.Backend.Responses;
using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;
using Newtonsoft.Json;

namespace Downloader.Backend.Services;

public class LegacyService : ILegacyService
{
    public IEnumerable<IBaseMod> GetMods(IEnumerable<string> urls)
    {
        var result = new List<IBaseMod>();
        using var client = new HttpClient();

        foreach (var url in urls)
        {
            var response = client.GetAsync(url).Result;
            if (!response.IsSuccessStatusCode)
            {
                continue;
            }

            var content = response.Content.ReadAsStringAsync().Result;
            var mods = JsonConvert.DeserializeObject<IEnumerable<LegacyMod>>(content);
            if (mods == null)
            {
                continue;
            }

            result.AddRange(mods.Select(mod => new BaseMod { Id = mod.Id }));
        }

        return result;
    }

    public IEnumerable<ILegacyModPack> GetModPacks(string url)
    {
        var result = new List<ILegacyModPack>();
        using var client = new HttpClient();
        var response = client.GetAsync(url).Result;
        if (!response.IsSuccessStatusCode)
        {
            return result;
        }

        var content = response.Content.ReadAsStringAsync().Result;
        var modPacks = JsonConvert.DeserializeObject<IEnumerable<LegacyModPack>>(content);
        if (modPacks == null)
        {
            return result;
        }
        
        result.AddRange(modPacks);
        return result;
    }
}