using Meetup.Domain.Interfaces.Repositories;
using Meetup.Domain.Models;
using Meetup.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Persistence.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationDbContext _context;

        public TagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _context.Tags.AsNoTracking().ToListAsync();
        }

        public async Task<bool> CreateAsync(Tag tag)
        {
            _ = await _context.Tags.AddAsync(tag);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Tag item = await _context.Tags.FindAsync(id);

            if (item != null)
            {
                _ = _context.Remove(item);

                return true;
            }

            return false;
        }

        public async Task<Tag> GetByIdAsync(Guid id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public Task<bool> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
