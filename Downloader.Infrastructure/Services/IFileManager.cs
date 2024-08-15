namespace Downloader.Infrastructure.Services;

public interface IFileManager
{
    Task DownloadFileAsync(string url, string path);
    Task DownloadFileAsync(string url, string path, CancellationToken cancellationToken);
    
    Task DownloadFilesAsync(IEnumerable<string> urls, string path);
    
    void CopyFile(string source, string destination);
}