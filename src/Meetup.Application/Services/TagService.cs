using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using Meetup.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<TagDTO>> GetAllAsync()
        {
            var tags = await _tagRepository.GetAllAsync();

            return null;
        }

        public async Task<TagDTO> GetItemByIdAsync(Guid itemId)
        {
            var tag = await _tagRepository.GetByIdAsync(itemId);

            return null;
        }

        public Task<TagDTO> CreateAsync(TagDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(Guid itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(TagDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
