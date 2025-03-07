﻿using DiningSolution.Domain.Entities;
using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Domain.Repositories
{
    public interface IPersonnelRepository
    {
        Task AddAsync(Personnel personnel);
        Task<Personnel> GetAsync(PersonnelID personnelID);
        Task UpdateAsync(Personnel personnel);
        Task DeleteAsync(PersonnelID personnelID);
    }
}
