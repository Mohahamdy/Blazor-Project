using Company.Models;

namespace Company.Services
{
    public interface IService<T>
    {
        public Task<List<T>> GetAll();

        public Task<T> GetById(int id);

        public Task Edit(int id,T entity);

        public Task Remove(int id);

        public Task Add(T entity);
    }
}
