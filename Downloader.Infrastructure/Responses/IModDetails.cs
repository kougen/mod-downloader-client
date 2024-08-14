namespace Downloader.Infrastructure.Responses;

public interface IModDetails : IBaseMod
{
    int GameId { get; }
    string Name { get; }
    string Slug { get; }
    string WebsiteUrl { get; }
    string Summary { get; }
    int Status { get; }
    int DownloadCount { get; }
    bool IsFeatured { get; }
    int PrimaryCategoryId { get; }
    IEnumerable<ICategory> Categories { get; }
    IEnumerable<IAuthor> Authors { get; }
    ILogo Logo { get; }
    IEnumerable<IFile> LatestFiles { get; }
    DateTime DateCreated { get; }
    DateTime DateModified { get; }
    DateTime DateReleased { get; }
    bool IsAvailable { get; }
}

