using Downloader.Infrastructure.Services;

namespace Downloader.Backend.Services;

public class FileManager : IFileManager
{
    public async Task DownloadFileAsync(string url, string path)
    {
        var tokenSource = new CancellationTokenSource();
        await DownloadFileAsync(url, path, tokenSource.Token);
    }

    public async Task DownloadFileAsync(string url, string path, CancellationToken cancellationToken)
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(url, cancellationToken);
        await using var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
        await response.Content.CopyToAsync(fileStream, cancellationToken);
    }
    
    public void CopyFile(string source, string destination)
    {
        File.Copy(source, destination, true);
    }
}