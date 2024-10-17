using Meetup.Domain.Models;
using System.Threading.Tasks;

namespace Meetup.Domain.Interfaces.Repositories
{
    public interface IMeetingRepository
    {
        Task GetAll();
        Task GetById();
        Task Create();
        Task Delete();
        Task Update();
    }
}
