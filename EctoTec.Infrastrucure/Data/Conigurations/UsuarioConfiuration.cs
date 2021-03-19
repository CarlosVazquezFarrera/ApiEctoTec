namespace EctoTec.Infrastrucure.Data.Conigurations
{
    using EctoTect.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class UsuarioConfiuration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.Property(e => e.Id).HasDefaultValueSql("(newid())");

            builder.Property(e => e.Fecha).HasColumnType("date");

            builder.Property(e => e.Mail)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.HasOne(d => d.IdCiudadNavigation)
                .WithMany(p => p.Usuario)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioCiudad");
        }
    }
}
