using BankApplication.Domain.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplication.Context.Contas
{
    public class ContasTypeConfiguration : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Codigo).HasMaxLength(19);

            builder.HasOne(q => q.Usuario).WithOne(q => q.Conta).HasForeignKey<Conta>(q => q.IdUsuario);
        }
    }
}