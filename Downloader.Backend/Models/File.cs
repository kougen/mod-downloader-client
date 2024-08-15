using Downloader.Infrastructure.Models;

namespace Downloader.Backend.Models;

public class File(string downloadUrl, string filePathOnDisk) : IFile
{
    public string DownloadUrl { get; } = downloadUrl;
    public string FilePathOnDisk { get; } = filePathOnDisk;
    public bool IsDownloaded { get; private set; } = false;
    
    public async Task DownloadAsync(CancellationToken cancellationToken)
    {
        using var client = new HttpClient();
        await DownloadAsync(client, cancellationToken);
    }

    public async Task DownloadAsync(HttpClient client, CancellationToken cancellationToken)
    {
        var response = await client.GetAsync(DownloadUrl, cancellationToken);
        await using var fileStream = new FileStream(FilePathOnDisk, FileMode.Create, FileAccess.Write, FileShare.None);
        await response.Content.CopyToAsync(fileStream, cancellationToken);
    }
}