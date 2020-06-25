using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public abstract class AbstractContext : DbContext
    {
        protected AbstractContext(DbContextOptions<AbstractContext> options) :  base(options){}
      
        #region DbSets

        internal DbSet<Musician> Musicians {get;set;}        
        internal DbSet<Genre> Genres {get;set;}       

        #endregion
    }
}