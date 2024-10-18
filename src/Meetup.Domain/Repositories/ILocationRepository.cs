using Meetup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllAsync();
        Task<Location> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(Location location);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Guid id);
    }
}
