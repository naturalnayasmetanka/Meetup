using Meetup.Application.DTOs;
using Meetup.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Services
{
    public class LocationService : IBaseService<LocationDTO>, ILocationService
    {
        public LocationService()
        {
            
        }

        public Task<LocationDTO> Create(LocationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDTO> Get(LocationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<LocationDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDTO> Remove(LocationDTO item)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDTO> Update(LocationDTO Item)
        {
            throw new System.NotImplementedException();
        }
    }
}
