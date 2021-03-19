using System;
using EctoTec.Infrastrucure.Data.Conigurations;
using EctoTect.Core.Entities;
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

        public EctoTecContext(DbContextOptions<EctoTecContext> options): base(options)
        {
        }

        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CiudadConfiguration());

            modelBuilder.ApplyConfiguration(new EntidadConfiuration());

            modelBuilder.ApplyConfiguration(new PaisConfiuration());

            modelBuilder.ApplyConfiguration(new UsuarioConfiuration());


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
