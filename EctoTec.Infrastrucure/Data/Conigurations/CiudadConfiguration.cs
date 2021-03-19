namespace EctoTec.Infrastrucure.Data.Conigurations
{
    using EctoTect.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {

            builder.ToTable("CIUDAD");

            builder.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.HasOne(d => d.IdEntiddNavigation)
                .WithMany(p => p.Ciudad)
                .HasForeignKey(d => d.IdEntidd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CiudadEntidad");
        }
    }
}
