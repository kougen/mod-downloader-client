using Downloader.Infrastructure.Models;

namespace Downloader.Infrastructure.Services;

public interface IFileManager
{
    Task DownloadFileAsync(string url, string path);
    Task DownloadFileAsync(string url, string path, CancellationToken cancellationToken);
    
    Task DownloadFilesAsync(IEnumerable<IFile> files, CancellationToken cancellationToken);
    
    void CopyFile(string source, string destination);
}