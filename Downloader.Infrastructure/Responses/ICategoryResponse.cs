namespace Downloader.Infrastructure.Responses;

/// <summary>
/// A General mod category.
/// </summary>
public interface ICategoryResponse
{
    int Id { get; }
    string Name { get; }
}