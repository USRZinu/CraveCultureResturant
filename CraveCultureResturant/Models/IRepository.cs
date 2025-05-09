using System.Linq.Expressions;

namespace CraveCultureResturant.Models
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>>GetAllByAsync<TKey>(TKey id, string propertyName, QueryOptions<T> options);
        Task<T> GetByIdAsync(int id,QueryOptions<T> options);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

    }
}
