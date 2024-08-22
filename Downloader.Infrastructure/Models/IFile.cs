namespace Downloader.Infrastructure.Models;

/// <summary>
/// IFile is managed by the IFileManager.
/// </summary>
public interface IFile
{
    /// <summary>
    /// Source of the file.
    /// </summary>
    string DownloadUrl { get; }
    
    /// <summary>
    /// The actual file path on disk. (It can be either a temporary file or the final file path)
    /// </summary>
    string FilePathOnDisk { get; }
    
    /// <summary>
    /// If the file is downloaded. It can be used to prevent downloading the same file multiple times.
    /// </summary>
    bool IsDownloaded { get; }
    
    /// <summary>
    /// Downloads the file.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DownloadAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Downloads the file using the provided HttpClient.
    /// </summary>
    /// <param name="client"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DownloadAsync(HttpClient client, CancellationToken cancellationToken);
}