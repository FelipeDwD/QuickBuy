using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using Dwd.Lab.Repositorio.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Dwd.Lab.Repositorio.Map
{
    public class ImagemProdutoMap : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.ToTable("ImagemProduto");
        }
    }
}
