using System.Text.Json.Serialization;
using ACM.Example.FileProcessor.Core.Interfaces;
using ACM.Example.FileProcessor.Functions.Constants;

namespace ACM.Example.FileProcessor.Events;

public class FileProcessedEvent : IEvent
{
    public Guid FileId { get; init; }

    [JsonIgnore]
    public string Topic { get; } = ServiceBusConstants.Topics.FileProcessorUpdates;
    
    [JsonIgnore]
    public string Label { get; } = ServiceBusConstants.Labels.FileProcessed;
}