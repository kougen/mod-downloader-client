using Downloader.Backend.Services;

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
        
        Assert.True(File.Exists(path));
    }
}