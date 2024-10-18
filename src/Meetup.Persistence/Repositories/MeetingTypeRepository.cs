using Meetup.Domain.Interfaces.Repositories;
using Meetup.Domain.Models;
using Meetup.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Persistence.Repositories
{
    public class MeetingTypeRepository : IMeetingTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public MeetingTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MeetingType>> GetAllAsync()
        {
            return await _context.MeetingTypes.AsNoTracking().ToListAsync();
        }

        public async Task<MeetingType> GetByIdAsync(Guid id)
        {
            return await _context.MeetingTypes.FindAsync(id);
        }

        public async Task<bool> CreateAsync(MeetingType type)
        {
            _ = await _context.MeetingTypes.AddAsync(type);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.MeetingTypes.FindAsync(id);

            if (item != null)
            {
                _ = _context.Remove(item);

                return true;
            }

            return false;
        }

        public Task<bool> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
