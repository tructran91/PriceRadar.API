using System.Linq.Expressions;

namespace PriceRadar.Core.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        int pageNumber = 1, int pageSize = 10,
                                        bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);

        Task<T> GetByIdAsync(Guid id);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task UpdateAsync(List<T> entities);

        Task DeleteAsync(T entity);
    }
}
