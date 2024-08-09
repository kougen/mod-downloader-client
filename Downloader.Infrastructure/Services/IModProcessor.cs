using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

/// <summary>
/// Converts the responses from the source into usable objects.
/// </summary>
public interface IModProcessor
{
    IModDetails? GetModDetails(string id);
    IModDetails? GetModDetails(int id);
    
    IEnumerable<IModDetails> GetModDetails(IEnumerable<string> ids);
    IEnumerable<IModDetails> GetModDetails(IEnumerable<int> ids);
}