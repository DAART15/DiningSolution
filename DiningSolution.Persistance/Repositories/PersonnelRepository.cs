using DiningSolution.Domain.Entities;
using DiningSolution.Domain.Repositories;
using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Persistance.Repositories
{
    internal class PersonnelRepository : IPersonnelRepository
    {
        public Task AddAsync(Personnel personnel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(PersonnelID personnelID)
        {
            throw new NotImplementedException();
        }

        public Task<Personnel> GetAsync(PersonnelID personnelID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Personnel personnel)
        {
            throw new NotImplementedException();
        }
    }
}
