namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Author of the mod.
/// </summary>
public interface IAuthorResponse
{
    /// <summary>
    /// ID of the author.
    /// </summary>
    int Id { get; }
    
    /// <summary>
    /// The name of the author.
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// The url for the author's profile.
    /// </summary>
    string Url { get; }
}
