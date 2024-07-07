namespace Downloader.Infrastructure.Responses;

public interface ICategory
{
    int Id { get; set; }
    int GameId { get; set; }
    string Name { get; set; }
    string Slug { get; set; }
    string Url { get; set; }
    string IconUrl { get; set; }
    DateTime DateModified { get; set; }
    bool IsClass { get; set; }
    int ClassId { get; set; }
    int ParentCategoryId { get; set; }
}
