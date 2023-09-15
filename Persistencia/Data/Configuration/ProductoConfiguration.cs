using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("producto");

            builder.Property(p => p.Nombre)
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(p => p.Precio)
            .HasColumnType("decimal")
            .IsRequired();

            builder
            .HasOne(p=>p.Marca)
            .WithMany(p=>p.Productos)
            .HasForeignKey(p=>p.MarcaId);

            builder
            .HasOne(p=>p.Categoria)
            .WithMany(p=>p.Productos)
            .HasForeignKey(p=>p.CategoriaId);
        }
    }
}