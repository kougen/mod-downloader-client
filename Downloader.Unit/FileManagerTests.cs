using System.Diagnostics;
using Downloader.Backend.Services;
using Downloader.Infrastructure.Models;
using File = Downloader.Backend.Models.File;

namespace Downloader.Unit;

public class FileManagerTests : ATestBase
{
    [Fact]
    public async void FM_0001_Given_CorrectUrl_When_DownloadFileAsyncCalled_Then_ReturnsFile()
    {
        var fileManager = new FileManager();
        var url = "https://link.testfile.org/PDF10MB";
        var path = GetPath("test.pdf");
        
        await fileManager.DownloadFileAsync(url, path);
        
        Assert.True(System.IO.File.Exists(path));
    }
    
    [Fact]
    public async void FM_0002_Given_CorrectUrl_When_DownloadFileAsyncCalled_Then_ReturnsFile()
    {
        var fileManager = new FileManager();
        var url = "https://link.testfile.org/PDF10MB";
        var path = GetPath("test.pdf");
        
        var tokenSource = new CancellationTokenSource();
        await fileManager.DownloadFileAsync(url, path, tokenSource.Token);
        
        Assert.True(System.IO.File.Exists(path));
    }
    
    [Fact]
    public async void Fm0003GivenCorrectUrlWhenDownloadFilesAsyncCalledSimultaniouslyThenReturnsFilesFm_0003_Given_Correcturl_When_Downloadfilesasynccalledsimultaneously_Then_Returnsfiles()
    {
        var timer = new Stopwatch();
        var files = new List<IFile>
        {
            new File("https://link.testfile.org/PDF10MB", GetPath("test.pdf")),
            new File("https://link.testfile.org/PDF10MB", GetPath("test3.pdf"))
        };

        timer.Start();
        foreach (var file in files)
        {
            await file.DownloadAsync(CancellationToken.None);
        }
        timer.Stop();
        
        Assert.True(timer.ElapsedMilliseconds < 40000);
    }
    
    [Fact]
    public async void FM_0003_Given_CorrectUrl_When_DownloadFilesAsyncCalled_Then_ReturnsFiles()
    {
        var fileManager = new FileManager();
        var files = new List<IFile>
        {
            new File("https://link.testfile.org/PDF10MB", GetPath("test.pdf")),
            new File("https://link.testfile.org/PDF10MB", GetPath("test3.pdf"))
        };
        var tokenSource = new CancellationTokenSource();
        var timer = new Stopwatch();
        
        timer.Start();
        await fileManager.DownloadFilesAsync(files, tokenSource.Token);
        timer.Stop();
        
        Assert.True(timer.ElapsedMilliseconds < 40000);
    }
}