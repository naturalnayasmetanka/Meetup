using Meetup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(Tag tag);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Guid id);
    }
}
