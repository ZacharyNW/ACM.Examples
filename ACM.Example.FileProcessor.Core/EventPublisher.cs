using System.Text.Json;
using ACM.Example.FileProcessor.Core.Interfaces;

namespace ACM.Example.FileProcessor.Core;

public class EventPublisher : IEventPublisher
{
    public Task PublishEvent<T>(T @event) where T : IEvent
    {
        Console.WriteLine(JsonSerializer.Serialize(@event));
        
        return Task.CompletedTask;
    }
}