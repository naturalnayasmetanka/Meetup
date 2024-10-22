using Meetup.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingDTO>> GetAll();
        Task<MeetingDTO> GetItem(MeetingDTO item);
        Task<MeetingDTO> Create(MeetingDTO item);
        Task<bool> Update(MeetingDTO Item);
        Task<bool> Remove(Guid itemId);
    }
}
