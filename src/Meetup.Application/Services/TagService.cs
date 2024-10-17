using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class TagService : IBaseService<TagDTO>, ITagService
    {
        public TagService()
        {
            
        }

        public Task<TagDTO> Create(TagDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<TagDTO> Get(TagDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<TagDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<TagDTO> Remove(TagDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<TagDTO> Update(TagDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
