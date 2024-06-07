using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class TipoProdutoMap : IEntityTypeConfiguration<TipoProdutoModel>
    {
        public void Configure(EntityTypeBuilder<TipoProdutoModel> builder)
        {
            builder.HasKey(x => x.TipoProdutoId);
            builder.Property(x => x.NomeTipoProduto).IsRequired().HasMaxLength(255);
        }
    }
}
