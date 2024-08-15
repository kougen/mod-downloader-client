using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

/// <summary>
/// Converts the responses from the source into usable objects.
/// </summary>
public interface IModProcessor
{
    IModResponseDetails? GetModDetails(string id);
    IModResponseDetails? GetModDetails(int id);
    
    IEnumerable<IModResponseDetails> GetModDetails(IEnumerable<string> ids);
    IEnumerable<IModResponseDetails> GetModDetails(IEnumerable<int> ids);
}