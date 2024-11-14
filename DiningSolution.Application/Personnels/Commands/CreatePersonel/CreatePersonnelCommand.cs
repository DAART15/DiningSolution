using DiningSolution.Application.Abstractions.Mesaging;
using DiningSolution.Domain.Shared;

namespace DiningSolution.Application.Personnels.Commands.CreatePersonel
{
    public sealed record CreatePersonnelCommand(string PersonnelName, string PersonnelPosition) : ICommand<int>
    {
    }
}
