using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class MeetingTypeService : IMeetingTypeService
    {
        public MeetingTypeService()
        {
            
        }

        public Task<MeetingTypeDTO> Create(MeetingTypeDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<MeetingTypeDTO> GetItem(MeetingTypeDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MeetingTypeDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(Guid itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(MeetingTypeDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
