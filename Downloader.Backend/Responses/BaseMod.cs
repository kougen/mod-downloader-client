using Downloader.Infrastructure.Responses;

namespace Downloader.Backend.Responses;

public class BaseMod : IBaseMod
{
    public string Id { get; set; }
}