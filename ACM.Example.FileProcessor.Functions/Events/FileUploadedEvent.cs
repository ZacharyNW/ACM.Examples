using System;

namespace ACM.Example.FileProcessor.Functions.Events;

public class FileUploadedEvent
{
    public Guid FileId { get; set; }
}