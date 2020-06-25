using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Data.Transaction;
using Domain.Entities;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        // attributes
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<TEntity> _dbSet;

        // constructor
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbSet = _unitOfWork.Context.Set<TEntity>();
        }
        
        // sync
        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            _dbSet.Attach(entity);
        }

        public bool Delete(string id)
        {
            TEntity existing = _dbSet.Find(id);
            if (existing != null) {
                _dbSet.Remove(existing);
                return true;
            }
            return false;
        }
 
        public TEntity Select(string id)
        {
            return _dbSet.Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<TEntity> Select(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsEnumerable<TEntity>();
        }
        
        public IEnumerable<TEntity> SelectAll()
        {
            return _dbSet.AsEnumerable<TEntity>();
        }      
    }
}