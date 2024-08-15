using Downloader.Infrastructure.Models;
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

    public async Task DownloadFilesAsync(IEnumerable<IFile> files, CancellationToken cancellationToken)
    {
        var tasks = files.Select(async file =>
        {
            await file.DownloadAsync(cancellationToken);
        });

        await Task.WhenAll(tasks);
    }

    public void CopyFile(string source, string destination)
    {
        File.Copy(source, destination, true);
    }
}