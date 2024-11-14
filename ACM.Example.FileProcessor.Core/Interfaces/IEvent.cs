namespace ACM.Example.FileProcessor.Core.Interfaces;

public interface IEvent
{
    public string Topic { get; }
    public string Label { get; }
}