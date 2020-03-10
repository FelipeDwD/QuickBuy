using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class SubCategoriaProdutoMap : IEntityTypeConfiguration<SubCategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<SubCategoriaProduto> builder)
        {
            builder.HasKey(scp => scp.Id);

            builder
                .Property(scp => scp.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(scp => scp.Descricao)
                .HasMaxLength(150);

            builder
                .HasMany(scp => scp.Produtos)
                .WithOne(p => p.SubCategoriaProduto)
                .HasForeignKey(p => p.SubCategoriaProdutoId);

            


            builder.ToTable("SubCategoriaProduto");


        }
    }
}
