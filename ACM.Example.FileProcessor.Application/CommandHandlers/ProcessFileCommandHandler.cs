using ACM.Example.FileProcessor.Commands;
using ACM.Example.FileProcessor.Core.Interfaces;
using ACM.Example.FileProcessor.Events;

namespace ACM.Example.FileProcessor.CommandHandlers;

public class ProcessFileCommandHandler : ICommandHandler<ProcessFileCommand>
{
    private readonly IEventPublisher _eventPublisher;

    public ProcessFileCommandHandler(IEventPublisher eventPublisher)
    {
        _eventPublisher = eventPublisher;
    }
    
    public Task HandleAsync(ProcessFileCommand command)
    {
        return _eventPublisher.PublishEvent(new FileProcessedEvent
        {
            FileId = command.FileId
        });
    }
}