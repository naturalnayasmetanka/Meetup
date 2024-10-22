using Meetup.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Interfaces
{
    public interface ILocationService
    {
        Task<List<LocationDTO>> GetAll();
        Task<LocationDTO> GetItem(LocationDTO item);
        Task<LocationDTO> Create(LocationDTO item);
        Task<bool> Update(LocationDTO Item);
        Task<bool> Remove(Guid itemId);
    }
}
