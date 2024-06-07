using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
        public class SecaoMap : IEntityTypeConfiguration<SecaoModel>
        {
            public void Configure(EntityTypeBuilder<SecaoModel> builder)
            {
                builder.HasKey(x => x.SecaoId);
                builder.Property(x => x.NomeSecao).IsRequired().HasMaxLength(255);
            }
        }
}
