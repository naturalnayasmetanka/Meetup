using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class MeetingService : IMeetingService
    {
        public MeetingService()
        {
            
        }

        public Task<MeetingDTO> Create(MeetingDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingDTO> GetItem(MeetingDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MeetingDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(Guid itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(MeetingDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
