using Downloader.Infrastructure.Responses;

namespace Downloader.Backend.Responses;

public class BaseMod(string id) : IBaseMod
{
    public string Id { get; } = id;
}