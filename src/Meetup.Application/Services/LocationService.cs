using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class LocationService : ILocationService
    {
        public LocationService()
        {
            
        }

        public Task<LocationDTO> Create(LocationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDTO> GetItem(LocationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<LocationDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(Guid itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(LocationDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
