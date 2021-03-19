using EctoTect.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EctoTec.Infrastrucure.Data.Conigurations
{
    public class EntidadConfiuration : IEntityTypeConfiguration<Entidad>
    {
        public void Configure(EntityTypeBuilder<Entidad> builder)
        {
            builder.ToTable("ENTIDAD");

            builder.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.HasOne(d => d.IdPaisNavigation)
                .WithMany(p => p.Entidad)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntidadPais");
        }
    }
}
