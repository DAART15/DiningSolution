using DiningSolution.Domain.Entities;
using DiningSolution.Domain.Repositories;
using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Persistance.TemporaryData
{
    internal class PersonnelTemporaryData : IPersonnelRepository
    {
        public List<Personnel> PersonnelData { get; set; } = [];

        public  async Task AddAsync(Personnel personnel)
        {
            await Task.Run(() => AddPersonnel(personnel));
        }

        public void AddPersonnel(Personnel personnel)
        {
            PersonnelData.Add(personnel);
        }

        public async Task DeleteAsync(PersonnelID personnelID)
        {
            await Task.Run(() => DeletePersonnel(personnelID));
        }

        public void DeletePersonnel(PersonnelID personnelID)
        {
            PersonnelData.Remove(PersonnelData.Find(p => p.PersonnelID == personnelID)!);
        }

        public async Task<Personnel> GetAsync(PersonnelID personnelID)
        {
            return await Task.Run(() => GetPersonnel(personnelID));
        }

        public Personnel GetPersonnel(PersonnelID personnelID)
        {
            return PersonnelData.Find(p => p.PersonnelID == personnelID)!;
        }

        public async Task UpdateAsync(Personnel personnel)
        {
            await Task.Run(() => UpdatePersonnel(personnel));
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            PersonnelData.Remove(PersonnelData.Find(p => p.PersonnelID == personnel.PersonnelID)!);
            PersonnelData.Add(personnel);
        }
    }
}