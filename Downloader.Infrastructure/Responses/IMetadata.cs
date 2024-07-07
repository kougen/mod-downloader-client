namespace Downloader.Infrastructure.Responses;

public interface IAuthor
{
    int Id { get; set; }
    string Name { get; set; }
    string Url { get; set; }
}

public interface ILogo
{
    int Id { get; set; }
    int ModId { get; set; }
    string Title { get; set; }
    string ThumbnailUrl { get; set; }
    string Url { get; set; }
}
