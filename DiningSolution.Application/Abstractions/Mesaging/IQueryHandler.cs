using DiningSolution.Domain.Shared;
using MediatR;

namespace DiningSolution.Application.Abstractions.Mesaging
{
    public interface IQueryHandler<TQuery, TResult>: IRequestHandler<TQuery, Result<TResult>> where TQuery : IQuery<TResult>
    {
    }
}
