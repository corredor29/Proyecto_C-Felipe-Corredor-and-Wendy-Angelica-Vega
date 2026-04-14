using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Gestion_vuelos.src.Modules.Aerolineas.infrastructure.Entity;

public class AerolineasEntityConfiguration : IEntityTypeConfiguration<AerolineasEntity>

{
    public void Configure(EntityTypeBuilder<AerolineasEntity> builder)
        {
            builder.ToTable("airlines");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();
                
            builder.Property(x => x.CodigoIata)
                .HasColumnName("CodigoIata")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Pais_Origen_Id)
                .HasColumnName("Country_Origen_Id")
                .IsRequired();

            builder.HasOne(x => x.Paises)
                .WithMany()
                .HasForeignKey(x => x.Pais_Origen_Id)
                .OnDelete(DeleteBehavior.Restrict);
                
            builder.Property(x => x.Activa)
                .HasColumnName("activa")
                .HasDefaultValue(true)
                .IsRequired();
        }
}
