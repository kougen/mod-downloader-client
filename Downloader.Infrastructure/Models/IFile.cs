namespace Downloader.Infrastructure.Models;

public interface IFile
{
    string DownloadUrl { get; }
    string FilePathOnDisk { get; }
    bool IsDownloaded { get; }
    
    Task DownloadAsync(CancellationToken cancellationToken);
    Task DownloadAsync(HttpClient client, CancellationToken cancellationToken);
}