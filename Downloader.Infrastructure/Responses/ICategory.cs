namespace Downloader.Infrastructure.Responses;

/// <summary>
/// A General mod category.
/// </summary>
public interface ICategory
{
    int Id { get; }
    string Name { get; }
}