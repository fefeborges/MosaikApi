using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class TamanhoMap: IEntityTypeConfiguration<TamanhoModel>
        {
            public void Configure(EntityTypeBuilder<TamanhoModel> builder)
            {
                builder.HasKey(x => x.TamanhoId);
                builder.Property(x => x.NomeTamanho).IsRequired().HasMaxLength(255);
            }
        }
    }
