using DiningSolution.Domain.Shared;
using MediatR;

namespace DiningSolution.Application.Abstractions.Mesaging
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result> where TCommand : ICommand
    {
    }
    public interface ICommandHandler<TCommand, TResult> : IRequestHandler<TCommand, Result<TResult>> where TCommand : ICommand<TResult>
    {
    }
}
