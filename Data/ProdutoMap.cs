using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.ProdutoId);
            builder.Property(x => x.NomeProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DescricaoProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FotoProduto).IsRequired();
            builder.Property(x => x.TipoProdutoId).IsRequired();
            builder.Property(x => x.PrecoProduto).IsRequired();
            builder.Property(x => x.QtdEstoque).IsRequired();
            builder.Property(x => x.MarcaId).IsRequired();
            builder.Property(x => x.SecaoId).IsRequired();
            builder.Property(x => x.TamanhoId).IsRequired();
        }
    }
}
