using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion_vuelos.src.Modules.Ciudades.infrastructure.Entity;

public class CiudadesEntityConfiguration : IEntityTypeConfiguration<CiudadesEntity>
{
    public void Configure(EntityTypeBuilder<CiudadesEntity> builder)
        {
            builder.ToTable("Cities");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PaisesId)
                .HasColumnName("Country_id")
                .IsRequired();

            builder.HasOne(x => x.Paises)
                .WithMany()
                .HasForeignKey(x => x.PaisesId)
                .OnDelete(DeleteBehavior.Restrict);
        }
}
