using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //Padrão fluent

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Preco)
                .IsRequired()
                .HasMaxLength(12);

            builder
                .HasMany(p => p.Imagens);

            builder.ToTable("Produto");
        }
    }
}
