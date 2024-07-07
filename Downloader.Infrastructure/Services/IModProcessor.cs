using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

public interface IModProcessor
{
    IModDetails? GetModDetails(string id);
    IModDetails? GetModDetails(int id);
    
    IEnumerable<IModDetails> GetModDetails(IEnumerable<string> ids);
    IEnumerable<IModDetails> GetModDetails(IEnumerable<int> ids);
}