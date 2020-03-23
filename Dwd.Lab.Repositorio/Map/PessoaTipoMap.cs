using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class PessoaTipoMap : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            //Padrão fluent

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Tipo)
                .IsRequired()
                .HasMaxLength(30);

            builder.ToTable("PessoaTipo");
            
        }
    }
}
