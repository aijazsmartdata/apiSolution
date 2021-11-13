using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositry.Abstract
{
    public interface IRepositry<T> where T : class
    {
        T Get<Tkey>(T id);
        List<T> GetAll();
        bool Add(T entity);
        void Insert(T entity);
        void Update(T entity);
        T GetSingle(Expression<Func<T, bool>> whereCondition);
        List<T> GetAll(Expression<Func<T, bool>> whereCondition);
        void Delete(T entity);
        int Save();
        Task<T> GetAsync<Tkey>(T id);
        Task<List<T>> GetAllAsync();
        Task<bool> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> whereCondition);
        Task DeleteAsync(T entity);
        Task<int> SaveAsync();
        List<T> GetFiltered(Expression<Func<T, bool>> whereCondition = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByID(Expression<Func<T, bool>> whereCondition = null, string includeProperties = "");
    }
}
