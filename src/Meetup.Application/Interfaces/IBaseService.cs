using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meetup.Application.Interfaces
{
    public interface IBaseService<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(T item);
        Task<T> Create(T item);
        Task<T> Update(T Item);
        Task<T> Remove(T item);
    }
}
