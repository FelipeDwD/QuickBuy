using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class RelacaoTipoMap : IEntityTypeConfiguration<RelacaoTipo>
    {
        public void Configure(EntityTypeBuilder<RelacaoTipo> builder)
        {
            //Padrão fluent

            builder.HasKey(rt => rt.Id);

            builder
                .Property(rt => rt.Descricao);

            builder.ToTable("RelacaoTipo");
        }
    }
}
