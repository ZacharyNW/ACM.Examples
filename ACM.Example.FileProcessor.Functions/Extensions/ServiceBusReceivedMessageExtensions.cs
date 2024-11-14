using System.Text.Json;
using Azure.Messaging.ServiceBus;

namespace ACM.Example.FileProcessor.Functions.Extensions;

internal static class ServiceBusReceivedMessageExtensions
{
    internal static T AsType<T>(this ServiceBusReceivedMessage message)
    {
        T @event = JsonSerializer.Deserialize<T>(message.Body);

        return @event;
    }
}