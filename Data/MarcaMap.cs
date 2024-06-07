using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MarcaMap : IEntityTypeConfiguration<MarcaModel>
    {
        public void Configure(EntityTypeBuilder<MarcaModel> builder)
        {
            builder.HasKey(x => x.MarcaId);
            builder.Property(x => x.NomeMarca).IsRequired().HasMaxLength(255);
        }
    }
}
