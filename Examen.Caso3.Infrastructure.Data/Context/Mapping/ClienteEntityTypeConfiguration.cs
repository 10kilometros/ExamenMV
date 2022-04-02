using Examen.Caso3.Domain.Aggregates.ClienteAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Caso3.Infrastructure.Data.Context.Mapping
{
    class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombres).IsRequired().HasColumnType("varchar(250)");
            builder.Property(x => x.Apellidos).IsRequired().HasColumnType("varchar(250)");
            builder.Property(x => x.Correo).IsRequired().HasColumnType("varchar(320)");
            builder.Property(x => x.FechaNacimiento).HasColumnType("datetime");
            builder.Property(x => x.Direccion).HasColumnType("varchar(800)");
            builder.HasIndex(x => x.Correo).IsUnique();

            builder.Property(x => x.Activo).IsRequired();
            builder.Property(x => x.FechaRegistro).IsRequired().HasColumnType("datetime");
        }
    }
}
