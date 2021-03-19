using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EctoTec.Infrastrucure.Data
{
    public partial class EctoTecContext : DbContext
    {
        public EctoTecContext()
        {
        }

        public EctoTecContext(DbContextOptions<EctoTecContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8HHRKK1\\SQLEXPRESS;Database=EctoTec;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.ToTable("CIUDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEntiddNavigation)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.IdEntidd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CiudadEntidad");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.ToTable("ENTIDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntidadPais");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("PAIS");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioCiudad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
