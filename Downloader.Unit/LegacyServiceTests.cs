using Downloader.Backend.Services;

namespace Downloader.Unit;

public class LegacyServiceTests
{
    [Fact]
    public void LST_0001_Given_CorrectUrl_When_GetModsCalled_Then_ReturnsMods()
    {
        var legacyRetriever = new LegacyService();
        var urls = Downloader.Infrastructure.Constants.GetLegacyModUrls();
        
        var mods = legacyRetriever.GetMods(urls);
        
        Assert.NotNull(mods);
        Assert.NotEmpty(mods);
    }
    
    [Fact]
    public void LST_0011_Given_CorrectUrl_When_GetModPacksCalled_Then_ReturnsModPacks()
    {
        var legacyRetriever = new LegacyService();
        var url = Downloader.Infrastructure.Constants.GetLegacyModPackUrl();
        
        var modPacks = legacyRetriever.GetModPacks(url);
        
        Assert.NotNull(modPacks);
        Assert.NotEmpty(modPacks);
    }
}