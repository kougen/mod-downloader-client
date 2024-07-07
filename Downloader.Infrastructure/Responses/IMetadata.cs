namespace Downloader.Infrastructure.Responses;

public interface IAuthor
{
    int Id { get; }
    string Name { get; }
    string Url { get; }
}

public interface ILogo
{
    int Id { get; }
    int ModId { get; }
    string Title { get; }
    string ThumbnailUrl { get; }
    string Url { get; }
}
