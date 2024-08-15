using Downloader.Backend.Services;
using Downloader.Infrastructure.Services;
using Implementation.Module;
using Infrastructure.Module;
using Microsoft.Extensions.DependencyInjection;

namespace Downloader.Backend;

public class Module(IServiceCollection collection) : AModule(collection), IBaseModule
{
    public override IModule RegisterServices(IServiceCollection collection)
    {
        collection.AddSingleton<ILegacyService, LegacyService>();
        return this;
    }
}