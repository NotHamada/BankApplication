using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Usuarios;
using BankApplication.Domain.Contas;

namespace BankApplication.Context.Types.Usuarios
{
    public class SedesTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(q => q.Id);

            builder.HasOne(q => q.Conta).WithOne(q => q.Usuario).HasForeignKey<Conta>(q => q.IdUsuario);
            builder.HasOne(q => q.Sede).WithMany(q => q.Usuarios).HasForeignKey(q => q.Id);
        }
    }
}