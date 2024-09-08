namespace Meetup.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        void GetAll();
        void GetByParam();
        void Create();
        void Update();
        void Delete();
    }
}
