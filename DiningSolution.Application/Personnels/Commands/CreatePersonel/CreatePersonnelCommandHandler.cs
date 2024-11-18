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

            /*if (personnelID.IsFailure) 
                return Result.Failure<int>(personnelID.Error);
            if (personnelName.IsFailure) 
                return Result.Failure<int>(personnelName.Error);
            if (personnelPosition.IsFailure)
                return Result.Failure<int>(personnelPosition.Error);
            */

            if(personnelID.IsFailure || personnelName.IsFailure || personnelPosition.IsFailure)
            {
                var error = personnelID.IsFailure ? personnelID.Error :
                            personnelName.IsFailure ? personnelName.Error :
                            personnelPosition.IsFailure ? personnelPosition.Error :
                            Error.NullValue;
                return Result.Failure<int>(error);
            }
            var personnel = Personnel.Create(personnelID.Value, personnelName.Value, personnelPosition.Value);

            
            await _personnelRepository.AddAsync(personnel);

            //UnitOfWork

            return personnel.PersonnelID.Value;
        }
    }
}
