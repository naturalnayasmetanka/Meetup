using Meetup.Domain.Models;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface ILocationRepository
    {
        Task GetAll();
        Task GetById();
        Task Create();
        Task Delete();
        Task Update();
    }
}
