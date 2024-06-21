using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.NomeCliente).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelefoneCliente).IsRequired();
            builder.Property(x => x.EmailCliente).IsRequired();
            builder.Property(x => x.CpfCliente).IsRequired();
            builder.Property(x => x.SenhaCliente).IsRequired();
        }
    }
}
