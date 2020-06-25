using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.IService
{
    public interface IMusicianService
    {
        Musician Add(Musician m);        
        Musician Update(Musician m);
        bool Delete(string id);
        Musician Get(string id);
        IEnumerable<Musician> Search(Expression<Func<Musician, bool>> expression);
        IEnumerable<Musician> List();
    }
}