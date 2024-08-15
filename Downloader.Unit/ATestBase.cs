using System.Reflection;
using Implementation.Module;
using Infrastructure.Module;
using Microsoft.Extensions.DependencyInjection;

namespace Downloader.Unit;

public class ATestBase
{
    protected IModule Core { get; }
    protected IBaseModule Test { get; }
    protected string TestDirectory { get; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
    protected string GetPath(string path) => Path.Combine(TestDirectory, path);

    protected IServiceProvider Services { get; }
    
    public ATestBase()
    {
        var services = new ServiceCollection();
        var cancellationTokenSource = new CancellationTokenSource();
        Core = new CoreModule(services, cancellationTokenSource);
        Core.RegisterServices();
        Test = new TestModule(services);
        Core.RegisterOtherServices(Test);
        
        Services = services.BuildServiceProvider();
    }
}