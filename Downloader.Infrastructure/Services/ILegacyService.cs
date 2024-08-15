using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

public interface ILegacyService
{
    /// <summary>
    /// Retrieve a list of mods from the given urls using async.
    /// </summary>
    /// <param name="urls"></param>
    /// <returns></returns>
    Task<IEnumerable<IBaseMod>> GetModsAsync(IEnumerable<string> urls);
    
    /// <summary>
    /// Retrieve a list of mods from the given urls.
    /// </summary>
    /// <param name="urls"></param>
    /// <returns></returns>
    IEnumerable<IBaseMod> GetMods(IEnumerable<string> urls);
    
    /// <summary>
    /// Retrieve a list of mod packs from the given url using async.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    Task<IEnumerable<ILegacyModPack>> GetModPacksAsync(string url);
    
    /// <summary>
    /// Retrieve a list of mod packs from the given url.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    IEnumerable<ILegacyModPack> GetModPacks(string url);
}