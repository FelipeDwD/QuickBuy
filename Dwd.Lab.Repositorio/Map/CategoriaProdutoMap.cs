using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class CategoriaProdutoMap : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder.HasKey(cp => cp.Id);

            builder
                .Property(cp => cp.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(cp => cp.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            builder.ToTable("CategoriaProduto");
        }
    }
}
