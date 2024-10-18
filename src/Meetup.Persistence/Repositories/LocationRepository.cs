using Meetup.Domain.Interfaces.Repositories;
using Meetup.Domain.Models;
using Meetup.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Persistence.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _context;

        public LocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await _context.Locations.AsNoTracking().ToListAsync();
        }

        public async Task<Location> GetByIdAsync(Guid id)
        {
            return await _context.Locations.FindAsync(id);
        }

        public async Task<bool> CreateAsync(Location location)
        {
            _ = await _context.Locations.AddAsync(location);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.Locations.FindAsync(id);

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
