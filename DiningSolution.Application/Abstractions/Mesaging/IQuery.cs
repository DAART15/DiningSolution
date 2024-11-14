using DiningSolution.Domain.Shared;
using MediatR;

namespace DiningSolution.Application.Abstractions.Mesaging
{
    public interface IQuery<TResult> : IRequest<Result<TResult>>
    {
    }
}
