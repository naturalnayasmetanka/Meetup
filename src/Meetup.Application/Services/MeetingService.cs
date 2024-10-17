using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class MeetingService : IBaseService<MeetingDTO>, IMeetingService
    {
        public MeetingService()
        {
            
        }

        public Task<MeetingDTO> Create(MeetingDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingDTO> Get(MeetingDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MeetingDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingDTO> Remove(MeetingDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingDTO> Update(MeetingDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
