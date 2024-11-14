using ACM.Example.FileProcessor.Core.Interfaces;

namespace ACM.Example.FileProcessor.Commands;

public class ProcessFileCommand : ICommand
{
    public Guid FileId { get; set; }
}