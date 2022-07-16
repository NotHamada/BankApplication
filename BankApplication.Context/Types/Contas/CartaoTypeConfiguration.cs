using BankApplication.Domain.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplication.Context.Types.Contas
{
    public class CartaoTypeConfiguration : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            builder.Property(q => q.NumeroDoCartao).HasMaxLength(3);
            builder.Property(q => q.SenhaDoCartao).HasMaxLength(4);
            builder.Property(q => q.LimiteDeCredito).HasPrecision(20, 2);

            builder.HasOne(q => q.Usuario).WithOne(q => q.Cartao);
        }
    }
}