using Downloader.Infrastructure.Responses;
using Newtonsoft.Json;

namespace Downloader.Backend.Responses;

public class ModDetails : IModDetails
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("gameId")] public int GameId { get; }

    [JsonProperty("name")] public string Name { get; }

    [JsonProperty("slug")] public string Slug { get; }

    [JsonProperty("websiteUrl")] public string WebsiteUrl { get; }

    [JsonProperty("summary")] public string Summary { get; }

    [JsonProperty("status")] public int Status { get; }

    [JsonProperty("downloadCount")] public int DownloadCount { get; }

    [JsonProperty("isFeatured")] public bool IsFeatured { get; }

    [JsonProperty("primaryCategoryId")] public int PrimaryCategoryId { get; }

    [JsonProperty("categories")] public IEnumerable<ICategory> Categories { get; }

    [JsonProperty("classId")] public int ClassId { get; }

    [JsonProperty("authors")] public IEnumerable<IAuthor> Authors { get; }

    [JsonProperty("logo")] public ILogo Logo { get; }

    [JsonProperty("mainFileId")] public int MainFileId { get; }

    [JsonProperty("latestFiles")] public IEnumerable<IFile> LatestFiles { get; }

    [JsonProperty("dateCreated")] public DateTime DateCreated { get; }

    [JsonProperty("dateModified")] public DateTime DateModified { get; }

    [JsonProperty("dateReleased")] public DateTime DateReleased { get; }

    [JsonProperty("allowModDistribution")] public bool AllowModDistribution { get; }

    [JsonProperty("gamePopularityRank")] public int GamePopularityRank { get; }

    [JsonProperty("isAvailable")] public bool IsAvailable { get; }

    [JsonProperty("thumbsUpCount")] public int ThumbsUpCount { get; }

    [JsonConstructor]
    public ModDetails(
        string id,
        int gameId,
        string name, string slug, string websiteUrl, string summary, int status, int downloadCount, bool isFeatured,
        int primaryCategoryId, IEnumerable<ICategory> categories, int classId, IEnumerable<IAuthor> authors, ILogo logo,
        int mainFileId, IEnumerable<IFile> latestFiles, DateTime dateCreated, DateTime dateModified,
        DateTime dateReleased, bool allowModDistribution, int gamePopularityRank, bool isAvailable, int thumbsUpCount)
    {
        Id = id;
        GameId = gameId;
        Name = name;
        Slug = slug;
        WebsiteUrl = websiteUrl;
        Summary = summary;
        Status = status;
        DownloadCount = downloadCount;
        IsFeatured = isFeatured;
        PrimaryCategoryId = primaryCategoryId;
        Categories = categories;
        ClassId = classId;
        Authors = authors;
        Logo = logo;
        MainFileId = mainFileId;
        LatestFiles = latestFiles;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateReleased = dateReleased;
        AllowModDistribution = allowModDistribution;
        GamePopularityRank = gamePopularityRank;
        IsAvailable = isAvailable;
        ThumbsUpCount = thumbsUpCount;
    }
}