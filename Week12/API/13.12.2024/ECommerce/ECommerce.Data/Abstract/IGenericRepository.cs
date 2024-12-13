using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Abstract
{
    public interface IGenericRepository<T>where T : class
    {
        Task<T> GetByIdAsync (int id);
        Task<T> GetAsync (Expression<Func<T, bool >> predicate, params Expression<Func<T,object>>[] includes);


        Task<IEnumerable<T>> GetAllAsync();
         
        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T,bool >> predicate=null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy=null,
            params Expression<Func<T, object>> [] includes
            );

        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task<bool> ExistAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}


//Categories.Where(x=>x.id, source.Include()x=>x.Category).Te)
// List<Category> categories = [6,4,7]
// Categories[1]