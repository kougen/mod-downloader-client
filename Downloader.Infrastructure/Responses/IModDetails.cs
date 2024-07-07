namespace Downloader.Infrastructure.Responses;

public interface IModDetails
{
    int Id { get; set; }
    int GameId { get; set; }
    string Name { get; set; }
    string Slug { get; set; }
    string WebsiteUrl { get; set; }
    string Summary { get; set; }
    int Status { get; set; }
    int DownloadCount { get; set; }
    bool IsFeatured { get; set; }
    int PrimaryCategoryId { get; set; }
    List<ICategory> Categories { get; set; }
    int ClassId { get; set; }
    List<IAuthor> Authors { get; set; }
    ILogo Logo { get; set; }
    int MainFileId { get; set; }
    List<IFile> LatestFiles { get; set; }
    DateTime DateCreated { get; set; }
    DateTime DateModified { get; set; }
    DateTime DateReleased { get; set; }
    bool AllowModDistribution { get; set; }
    int GamePopularityRank { get; set; }
    bool IsAvailable { get; set; }
    int ThumbsUpCount { get; set; }
}

