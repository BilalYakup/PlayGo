using PlayGo.Models.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace PlayGo.Infrastructure.Repositories.Interfaces
{
    

    public interface IBaseRepository<T> where T : BaseEntity
    {
      
        Task AddAsync(T entity);
        
        Task UpdateAsync(T entity);
        
        Task DeleteAsync(T entity);
        
        Task<bool> AnyAsync(int id);
        
        Task<T> GetByIdAsync(int id);
        
        Task<List<T>> GetAllAsync();

        Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                     Expression<Func<T, bool>> where = null,
                                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
                                                     Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
    }
}
