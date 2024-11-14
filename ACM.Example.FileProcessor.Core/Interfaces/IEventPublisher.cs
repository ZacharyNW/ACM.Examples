namespace ACM.Example.FileProcessor.Core.Interfaces;

public interface IEventPublisher
{
    Task PublishEvent<T>(T @event) where T : IEvent;
}