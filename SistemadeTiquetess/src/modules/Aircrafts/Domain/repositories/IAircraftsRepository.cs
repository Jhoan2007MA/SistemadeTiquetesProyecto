using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemadeTiquetess.src.modules.Aircrafts.Domain;

namespace SistemadeTiquetess.src.modules.Aircrafts.Domain.Repositories;

public interface IAircraftsRepository
{
    Task<IEnumerable<Aircraft>> GetAllAsync();
    Task<Aircraft?> GetByIdAsync(Guid id);
    Task AddAsync(Aircraft aircraft);
    Task UpdateAsync(Aircraft aircraft);
    Task DeleteAsync(Guid id);
}
