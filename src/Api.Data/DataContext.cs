using Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : AbstractContext
    {
        public DataContext(DbContextOptions<AbstractContext> options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MusicianMapping());
            modelBuilder.ApplyConfiguration(new GenreMapping());
        }
    }
}