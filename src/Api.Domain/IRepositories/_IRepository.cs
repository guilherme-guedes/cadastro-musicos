using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        // Async
        // Task<TEntity> InsertAsync(TEntity entity);
        // Task<TEntity> UpdateAsync(TEntity entity);
        // Task<bool> DeleteAsync(string id);
        // Task<TEntity> SelectAsync(string id);
        // Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate);
        // Task<IEnumerable<TEntity>> SelectAllAsync();

        // sync
        void Insert(TEntity entity);     
        void Update(TEntity entity);   
        bool Delete(string id);      
        TEntity Select(string id);
        IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> SelectAll();        
    }
}