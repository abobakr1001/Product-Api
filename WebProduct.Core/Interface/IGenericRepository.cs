using System.Linq.Expressions;
using WebProduct.Core.Entities;

namespace WebProduct.Core.Interface
{
    public interface IGenericRepository<T> where T : BasicEntity<int>
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);

        Task<T> GetByidAsync(int id, params Expression<Func<T, object>>[] includes);



        Task<T> GetAsync(int id);
        Task AddAsync(T Entity);
        Task DeleteAsync(int id);

        Task UpdateAsync(int id, T Entity);
        Task<int> CountAsync();
    }
}
