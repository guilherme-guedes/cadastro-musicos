
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class MusicianMapping : EntityMapping<Musician>
    {
        public override void ConfigureCustomFields(EntityTypeBuilder<Musician> builder)
        {
            builder.ToTable("Musicians");      
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Email).IsRequired();
        }
    }
}