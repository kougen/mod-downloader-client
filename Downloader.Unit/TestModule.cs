using Implementation.Module;
using Infrastructure.Configuration;
using Infrastructure.Configuration.Factories;
using Infrastructure.Module;
using Microsoft.Extensions.DependencyInjection;

namespace Downloader.Unit;

/// <summary>
/// A base module for the test project.
/// </summary>
/// <param name="collection"></param>
public class TestModule(IServiceCollection collection) : AModule(collection), IBaseModule
{
    public override IModule RegisterServices(IServiceCollection collection)
    {
        collection.AddSingleton<IConfigurationQuery>(p =>
        {
            var currentPath = Directory.GetCurrentDirectory();
            var testConfigurationPath = Path.Combine(currentPath, "testConfiguration.json");
            var factory = p.GetRequiredService<IConfigurationQueryFactory>();
            var configuration = factory.CreateConfigurationQuery(testConfigurationPath);
            configuration.SetAttribute("testKey", "testValue");
            return configuration;
        });
        return this;
    }
}