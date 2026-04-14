using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion_vuelos.src.Modules.Aeropuerto.infrastructure.Entity;

public class AeropuertoEntityConfiguration : IEntityTypeConfiguration<AeropuertoEntity>
{
    public void Configure(EntityTypeBuilder<AeropuertoEntity> builder)
        {
            builder.ToTable("airport");

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

            builder.Property(x => x.Ciudad_Id)
                .HasColumnName("Ciudad_Id")
                .IsRequired();

            builder.HasOne(x => x.Ciudades)
                .WithMany()
                .HasForeignKey(x => x.Ciudad_Id)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
}
