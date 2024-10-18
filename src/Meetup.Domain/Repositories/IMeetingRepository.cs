using Meetup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface IMeetingRepository
    {
        Task<IEnumerable<Meeting>> GetAllAsync();
        Task<Meeting> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(Meeting meeting);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Guid id);
    }
}
