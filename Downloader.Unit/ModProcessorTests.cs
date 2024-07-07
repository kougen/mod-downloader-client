using Downloader.Backend.Services;
using Infrastructure.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Downloader.Unit;

public class ModProcessorTests : ATestBase
{
    [Fact]
    public void MPT_0001_Given_CorrectId_When_GetModDetailsCalled_Then_ReturnsModDetails()
    {
        var query = Services.GetRequiredService<IConfigurationQuery>();
        var key = query.GetStringAttribute("curseForge.apiKey");
        Assert.NotNull(key);
        var modProcessor = new ModProcessor(key);
        var id = "3418627";
        
        var modDetails = modProcessor.GetModDetails(id);
        
        Assert.NotNull(modDetails);
    }
}