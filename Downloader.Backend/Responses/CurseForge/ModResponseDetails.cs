using Downloader.Infrastructure.Responses;
using Newtonsoft.Json;

namespace Downloader.Backend.Responses.CurseForge;

[method: JsonConstructor]
public class ModResponseDetails(
    string id,
    int gameId,
    string name,
    string slug,
    string websiteUrl,
    string summary,
    int status,
    int downloadCount,
    bool isFeatured,
    int primaryCategoryId,
    IEnumerable<ICategoryResponse> categories,
    int classId,
    IEnumerable<IAuthorResponse> authors,
    ILogoResponse logoResponse,
    int mainFileId,
    IEnumerable<IFileResponse> latestFiles,
    DateTime dateCreated,
    DateTime dateModified,
    DateTime dateReleased,
    bool allowModDistribution,
    int gamePopularityRank,
    bool isAvailable,
    int thumbsUpCount)
    : IModResponseDetails
{
    [JsonProperty("id")] public string Id { get; set; } = id;

    [JsonProperty("gameId")] public int GameId { get; } = gameId;

    [JsonProperty("name")] public string Name { get; } = name;

    [JsonProperty("slug")] public string Slug { get; } = slug;

    [JsonProperty("websiteUrl")] public string WebsiteUrl { get; } = websiteUrl;

    [JsonProperty("summary")] public string Summary { get; } = summary;

    [JsonProperty("status")] public int Status { get; } = status;

    [JsonProperty("downloadCount")] public int DownloadCount { get; } = downloadCount;

    [JsonProperty("isFeatured")] public bool IsFeatured { get; } = isFeatured;

    [JsonProperty("primaryCategoryId")] public int PrimaryCategoryId { get; } = primaryCategoryId;

    [JsonProperty("categories")] public IEnumerable<ICategoryResponse> Categories { get; } = categories;

    [JsonProperty("classId")] public int ClassId { get; } = classId;

    [JsonProperty("authors")] public IEnumerable<IAuthorResponse> Authors { get; } = authors;

    [JsonProperty("logo")] public ILogoResponse LogoResponse { get; } = logoResponse;

    [JsonProperty("mainFileId")] public int MainFileId { get; } = mainFileId;

    [JsonProperty("latestFiles")] public IEnumerable<IFileResponse> LatestFiles { get; } = latestFiles;

    [JsonProperty("dateCreated")] public DateTime DateCreated { get; } = dateCreated;

    [JsonProperty("dateModified")] public DateTime DateModified { get; } = dateModified;

    [JsonProperty("dateReleased")] public DateTime DateReleased { get; } = dateReleased;

    [JsonProperty("allowModDistribution")] public bool AllowModDistribution { get; } = allowModDistribution;

    [JsonProperty("gamePopularityRank")] public int GamePopularityRank { get; } = gamePopularityRank;

    [JsonProperty("isAvailable")] public bool IsAvailable { get; } = isAvailable;

    [JsonProperty("thumbsUpCount")] public int ThumbsUpCount { get; } = thumbsUpCount;
}