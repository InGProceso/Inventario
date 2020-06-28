using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class InventarioContext : DbContext
    {
        public InventarioContext()
        {
        }

        public InventarioContext(DbContextOptions<InventarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosPorTiendas> ProductosPorTiendas { get; set; }
        public virtual DbSet<Tiendas> Tiendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.ProductoId);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductosPorTiendas>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Producto)
                    .WithMany()
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductosPorTiendas_Productos");

                entity.HasOne(d => d.Tienda)
                    .WithMany()
                    .HasForeignKey(d => d.TiendaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductosPorTiendas_Tiendas");
            });

            modelBuilder.Entity<Tiendas>(entity =>
            {
                entity.HasKey(e => e.TiendaId);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
