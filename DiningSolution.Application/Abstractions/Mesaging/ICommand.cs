using DiningSolution.Domain.Shared;
using MediatR;

namespace DiningSolution.Application.Abstractions.Mesaging
{
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResult> : IRequest<Result<TResult>>
    {
    }
}
