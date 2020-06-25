using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.IRepositories;
using Domain.IService;

namespace Service.Services
{
    public class MusicianService : IMusicianService
    {
        private readonly IMusicianRepository _repository;

        public MusicianService(IMusicianRepository repository)
        {
            this._repository = repository;
        }

        public Musician Add(Musician m)
        {
            this._repository.Insert(m);
            return m;
        }

        public Musician Update(Musician m)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            return this._repository.Delete(id);
        }

        public Musician Get(string id)
        {
            return this._repository.Select(id);
        }

        public IEnumerable<Musician> Search(Expression<Func<Musician, bool>> expression)
        {
            return this._repository.Select(expression);
        }
        
        public IEnumerable<Musician> List()
        {
            return this._repository.SelectAll();
        }
    }
}