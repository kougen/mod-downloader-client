using Downloader.Infrastructure.Responses.CurseForge;

namespace Downloader.Infrastructure.Responses;

/// <summary>
/// The response structure for the mod details.
/// </summary>
public interface IModResponseDetails : IBaseModResponse
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
    IEnumerable<ICategoryResponse> Categories { get; }
    IEnumerable<IAuthorResponse> Authors { get; }
    ILogoResponse LogoResponse { get; }
    IEnumerable<IFileResponse> LatestFiles { get; }
    DateTime DateCreated { get; }
    DateTime DateModified { get; }
    DateTime DateReleased { get; }
    bool IsAvailable { get; }
}

