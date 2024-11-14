using System.Threading.Tasks;
using ACM.Example.FileProcessor.Commands;
using ACM.Example.FileProcessor.Core.Interfaces;
using ACM.Example.FileProcessor.Functions.Constants;
using ACM.Example.FileProcessor.Functions.Events;
using ACM.Example.FileProcessor.Functions.Extensions;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.ServiceBus;

namespace ACM.Example.FileProcessor.Functions.Listeners;

public class FileUploadedListener
{
    private readonly ICommandHandler<ProcessFileCommand> _commandHandler;

    public FileUploadedListener(ICommandHandler<ProcessFileCommand> commandHandler)
    {
        _commandHandler = commandHandler;
    }
    
    [FunctionName("FileUploadedListener")]
    public async Task RunAsync([ServiceBusTrigger(ServiceBusConstants.Topics.FileUploadUpdates,
            ServiceBusConstants.Subscription,
            Connection = "ServiceBusConnectionString")]
        ServiceBusReceivedMessage message,
        ServiceBusMessageActions actions)
    {
        var serviceBusEvent = message.AsType<FileUploadedEvent>();
        
        await _commandHandler.HandleAsync(new ProcessFileCommand
        {
            FileId = serviceBusEvent.FileId
        });
    }
}