using Meetup.Domain.Interfaces.Repositories;
using Meetup.Domain.Models;
using Meetup.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Persistence.Repositories
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly ApplicationDbContext _context;

        public MeetingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Meeting>> GetAllAsync()
        {
            return await _context.Meetings.AsNoTracking().ToListAsync();
        }

        public async Task<Meeting> GetByIdAsync(Guid id)
        {
            return await _context.Meetings.FindAsync(id);
        }

        public async Task<bool> CreateAsync(Meeting meeting)
        {
            _ = await _context.Meetings.AddAsync(meeting);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.Meetings.FindAsync(id);

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
