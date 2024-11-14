using ACM.Example.FileProcessor.Constants;
using ACM.Example.FileProcessor.Core;
using ACM.Example.FileProcessor.Core.Extensions;
using ACM.Example.FileProcessor.Core.Interfaces;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace ACM.Example.FileProcessor.Functions;

[assembly: FunctionsStartup(typeof(Startup))]

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddScoped<IEventPublisher, EventPublisher>();
        builder.Services.AddHandlersFromAssemblyContainingType<Application>();
    }
}