using Downloader.Backend.Services;

namespace Downloader.Unit;

public class LegacyRetrieverTests
{
    [Fact]
    public void LRT_0001_Given_CorrectUrl_When_GetModsCalled_Then_ReturnsMods()
    {
        var legacyRetriever = new LegacyModRetriever();
        var urls = Downloader.Infrastructure.Constants.GetLegacyModUrls();
        
        var mods = legacyRetriever.GetMods(urls);
        
        Assert.NotNull(mods);
    }
}