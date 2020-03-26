using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            //Padrão fluent

            builder.HasKey(e => e.Id);


            builder
                .Property(e => e.Sigla)
                .IsRequired()
                .HasMaxLength(2);

            builder
                .Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasMany(e => e.Cidades)
                .WithOne(c => c.Estado)
                .HasForeignKey(c => c.EstadoId);

            builder.ToTable("Estado");
        }
    }
}
