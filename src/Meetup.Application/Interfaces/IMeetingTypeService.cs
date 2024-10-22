using Meetup.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Interfaces
{
    public interface IMeetingTypeService
    {
        Task<List<MeetingTypeDTO>> GetAll();
        Task<MeetingTypeDTO> GetItem(MeetingTypeDTO item);
        Task<MeetingTypeDTO> Create(MeetingTypeDTO item);
        Task<bool> Update(MeetingTypeDTO Item);
        Task<bool> Remove(Guid itemId);
    }
}
