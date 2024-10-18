using Meetup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface IMeetingTypeRepository
    {
        Task<IEnumerable<MeetingType>> GetAllAsync();
        Task<MeetingType> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(MeetingType type);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Guid id);
    }
}
