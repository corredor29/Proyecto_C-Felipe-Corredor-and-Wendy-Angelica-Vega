using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion_vuelos.src.Modules.TipoDocumento.infrastructure.Entity;

public class TipoDocumentoEntityConfiguration : IEntityTypeConfiguration<TipoDocumentoEntity>
{
 public void Configure(EntityTypeBuilder<TipoDocumentoEntity> builder)
        {
            builder.ToTable("DocumentType");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();
                
            builder.Property(x => x.Codigo)
                .HasColumnName("codigo")
                .HasMaxLength(10)
                .IsRequired();

            builder.HasIndex(x => x.Codigo)
                .IsUnique();

                
        }
}
