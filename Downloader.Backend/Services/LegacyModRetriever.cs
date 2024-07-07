using System.Text.Json;
using Downloader.Backend.Responses;
using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;
using Newtonsoft.Json;

namespace Downloader.Backend.Services;

public class LegacyModRetriever : IModRetriever
{
    public IBaseMod GetMod(string url)
    {
        throw new NotImplementedException();
    }

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
}