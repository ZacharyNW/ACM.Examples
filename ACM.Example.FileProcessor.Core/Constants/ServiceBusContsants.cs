namespace ACM.Example.FileProcessor.Functions.Constants;

public static class ServiceBusConstants
{
    public const string Subscription = "FileProcessor";
    
    public static class Topics
    {
        public const string FileProcessorUpdates = nameof(FileProcessorUpdates);
        public const string FileUploadUpdates = nameof(FileUploadUpdates);
    }

    public static class Labels
    {
        public const string FileProcessed = nameof(FileProcessed);
        public const string FileUploaded = nameof(FileUploaded);
    }
}