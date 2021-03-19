namespace EctoTec.Infrastrucure.Data.Conigurations
{
    using EctoTect.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class PaisConfiuration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("PAIS");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
