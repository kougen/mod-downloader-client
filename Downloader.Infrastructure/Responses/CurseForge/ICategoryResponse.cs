namespace Downloader.Infrastructure.Responses.CurseForge;


/// <summary>
/// A category structure for CurseForge mod categories.
/// </summary>
public interface ICategoryResponse : Responses.ICategory
{
    int GameId { get; }
    string Slug { get; }
    string Url { get; }
    string IconUrl { get; }
    DateTime DateModified { get; }
    bool IsClass { get; }
    int ParentCategoryId { get; }
}