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

            builder
                .HasMany(cp => cp.Produtos)
                .WithOne(p => p.CategoriaProduto)
                .HasForeignKey(p => p.CategoriaProdutoId);

            builder
                .HasMany(cp => cp.SubCategoriaProdutos)
                .WithOne(scp => scp.CategoriaProduto)
                .HasForeignKey(scp => scp.CategoriaProdutoId);

           

            builder.ToTable("CategoriaProduto");
        }
    }
}
