using Meetup.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Interfaces
{
    public interface ITagService
    {
        Task<List<TagDTO>> GetAllAsync();
        Task<TagDTO> GetItemByIdAsync(Guid itemId);
        Task<TagDTO> CreateAsync(TagDTO item);
        Task<bool> Update(TagDTO Item);
        Task<bool> Remove(Guid itemId);
    }
}
