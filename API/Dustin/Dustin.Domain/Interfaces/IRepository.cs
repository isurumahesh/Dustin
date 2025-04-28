namespace Dustin.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> GetAll();

        public Task<T> Get(Guid id);
    }
}