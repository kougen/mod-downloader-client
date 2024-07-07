using Downloader.Infrastructure.Responses;

namespace Downloader.Infrastructure.Services;

public interface IModRetriever
{
    IBaseMod GetMod(string url);
}