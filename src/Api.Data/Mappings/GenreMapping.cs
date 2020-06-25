using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings{
    public class GenreMapping : EntityMapping<Genre>
    {
        public override void ConfigureCustomFields(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");      
            builder.Property(m => m.Name).IsRequired();
        }
    }
}