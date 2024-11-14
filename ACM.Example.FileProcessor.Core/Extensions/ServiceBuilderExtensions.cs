using ACM.Example.FileProcessor.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ACM.Example.FileProcessor.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHandlersFromAssemblyContainingType<T>(this IServiceCollection services)
        where T : class
    {
        var assembly = typeof(T).Assembly;
        IEnumerable<Type> types = assembly.GetTypes().Where(type => !type.IsAbstract && !type.IsInterface);
        foreach (Type type in types)
        {
            Type[] typeInterfaces = type.GetInterfaces();
            foreach (Type typeInterface in typeInterfaces)
            {
                if (typeInterface.IsGenericType && typeInterface.GetGenericTypeDefinition() == typeof(ICommandHandler<>))
                {
                    services.AddScoped(typeInterface, type);
                }
                
                if (typeInterface.IsGenericType && typeInterface.GetGenericTypeDefinition() == typeof(ICommandHandler<,>))
                {
                    services.AddScoped(typeInterface, type);
                }
            }
        }
        
        return services;
    }
}