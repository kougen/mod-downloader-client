namespace Downloader.Infrastructure.Responses;

/// <summary>
/// Author of the mod.
/// </summary>
public interface IAuthor
{
    int Id { get; }
    string Name { get; }
    string Url { get; }
}

/// <summary>
/// Logo of the mod.
/// </summary>
public interface ILogo
{
    int Id { get; }
    
    int ModId { get; }
    
    string Title { get; }
    
    /// <summary>
    /// A resized version of the logo.
    /// </summary>
    string ThumbnailUrl { get; }
    
    string Url { get; }
}
