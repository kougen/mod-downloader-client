namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Mod category.
/// </summary>
public interface ICategory
{
    int Id { get; }
    int GameId { get; }
    string Name { get; }
    string Slug { get; }
    string Url { get; }
    string IconUrl { get; }
    DateTime DateModified { get; }
    bool IsClass { get; }
    int ParentCategoryId { get; }
}