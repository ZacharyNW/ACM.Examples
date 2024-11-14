namespace ACM.Example.FileProcessor.Core.Interfaces;

public interface ICommandHandler<in TCommand> 
    where TCommand : ICommand
{
    public Task HandleAsync(TCommand command);
}

public interface ICommandHandler<in TCommand, TResult> 
    where TCommand : ICommand
{
    public Task<TResult> HandleAsync(TCommand command);
}