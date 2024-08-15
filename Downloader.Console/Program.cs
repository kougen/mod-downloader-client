using Downloader.Backend;
using Downloader.Infrastructure.Responses;
using Downloader.Infrastructure.Services;
using Implementation.Module;
using Infrastructure.IO;
using Infrastructure.Navigator.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Downloader.Console;
using Console = System.Console;

internal static class Program
{
    private static readonly IServiceProvider _serviceProvider;
    static Program()
    {
        var serviceCollection = new ServiceCollection();
        var tokenSource = new CancellationTokenSource();
        var coreModule = new CoreModule(serviceCollection, tokenSource);
        coreModule.RegisterOtherServices(new Module(serviceCollection));
        coreModule.RegisterServices("ModDownloader");
        
        _serviceProvider = serviceCollection.BuildServiceProvider();
    }
    
    static async Task Main(string[] args)
    {
        var writer = _serviceProvider.GetRequiredService<IWriter>();
        var elementFactory = _serviceProvider.GetRequiredService<INavigatorElementFactory>();
        var service = _serviceProvider.GetRequiredService<ILegacyService>();

        var mods = await service.GetModsAsync(Infrastructure.Constants.GetLegacyModUrls());
        var elements = mods
            .Select(m => elementFactory.CreateNavigatorElement<ILegacyMod>($"{m.FileName}", m))
            .ToList();
        var nav = _serviceProvider.GetRequiredService<INavigatorFactory>().CreateNavigator<ILegacyMod>(writer);
        nav.UpdateItems(elements);
        var selected = nav.Show();
        Console.WriteLine(selected.FileName);
    }
}