using Downloader.Infrastructure.Responses;

namespace Downloader.Backend.Responses;

public class BaseModResponse : IBaseModResponse
{
    public string Id { get; set; }
}