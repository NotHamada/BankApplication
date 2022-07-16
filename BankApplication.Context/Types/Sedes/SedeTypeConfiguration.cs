using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Sedes;

namespace BankApplication.Context.Types.Sedes
{
    public class SedesTypeConfiguration : IEntityTypeConfiguration<Sede>
    {
        public void Configure(EntityTypeBuilder<Sede> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Cidade).HasMaxLength(50);

            builder.HasMany(q => q.Usuarios).WithOne(q => q.Sede).HasForeignKey(q => q.Id);
            builder.HasMany(q => q.Contas).WithOne(q => q.Sede).HasForeignKey(q => q.Id);
        }
    }
}