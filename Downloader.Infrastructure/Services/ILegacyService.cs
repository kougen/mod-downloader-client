using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

public interface ILegacyService
{
    IEnumerable<IBaseMod> GetMods(IEnumerable<string> urls);
    
    IEnumerable<ILegacyModPack> GetModPacks(string url);
}