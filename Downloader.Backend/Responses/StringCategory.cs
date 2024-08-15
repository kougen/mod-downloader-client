using Downloader.Infrastructure.Responses;

namespace Downloader.Backend.Responses;

public class StringCategory : ICategory
{
    public int Id { get; }
    public int GameId { get; }
    public string Name { get; }
    public string Slug { get; }
    public string Url { get; }
    public string IconUrl { get; }
    public DateTime DateModified { get; }
    public bool IsClass { get; }
    public int ParentCategoryId { get; }
}