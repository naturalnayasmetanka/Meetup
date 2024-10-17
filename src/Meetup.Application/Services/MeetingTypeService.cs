using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class MeetingTypeService : IBaseService<MeetingTypeDTO>, IMeetingTypeService
    {
        public MeetingTypeService()
        {
            
        }

        public Task<MeetingTypeDTO> Create(MeetingTypeDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingTypeDTO> Get(MeetingTypeDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MeetingTypeDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingTypeDTO> Remove(MeetingTypeDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingTypeDTO> Update(MeetingTypeDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
