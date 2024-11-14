using DiningSolution.Application.Abstractions.Mesaging;
using DiningSolution.Domain.Entities;
using DiningSolution.Domain.Repositories;
using DiningSolution.Domain.Shared;
using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Application.Personnels.Commands.CreatePersonel
{
    internal sealed class CreatePersonnelCommandHandler(IPersonnelRepository personnelRepository) : ICommandHandler<CreatePersonnelCommand, int>
    {
        private readonly IPersonnelRepository _personnelRepository = personnelRepository;
        public async Task<Result<int>> Handle(CreatePersonnelCommand request, CancellationToken cancellationToken)
        {
            var personnelID = PersonnelID.Create();
            var personnelName = PersonnelName.Create(request.PersonnelName);
            var personnelPosition = PersonnelPosition.Create(request.PersonnelPosition);
            var personnel = Personnel.Create(personnelID.Value, personnelName.Value, personnelPosition.Value);
            await _personnelRepository.AddAsync(personnel);

            //UnitOfWork

            return personnel.PersonnelID.Value;
        }
    }
}
