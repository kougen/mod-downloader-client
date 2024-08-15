namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Logo of the mod.
/// </summary>
public interface ILogo
{
    /// <summary>
    /// Id of the logo.
    /// </summary>
    int Id { get; }
    
    /// <summary>
    /// The mod id to which the logo belongs.
    /// </summary>
    int ModId { get; }
    
    /// <summary>
    /// Title of the logo. Usually the name of the mod.
    /// </summary>
    string Title { get; }
    
    /// <summary>
    /// A resized version of the logo.
    /// </summary>
    string ThumbnailUrl { get; }
    
    /// <summary>
    /// The original size of the meta
    /// </summary>
    string Url { get; }
}
