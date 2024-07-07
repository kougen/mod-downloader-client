using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;

namespace Downloader.Backend.Services;

public class LegacyModRetriever : IModRetriever
{
    public IBaseMod GetMod(string url)
    {
        throw new NotImplementedException();
    }
}