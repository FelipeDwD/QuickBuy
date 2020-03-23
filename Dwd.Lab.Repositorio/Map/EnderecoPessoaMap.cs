using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class EnderecoPessoaMap : IEntityTypeConfiguration<EnderecoPessoa>
    {
        public void Configure(EntityTypeBuilder<EnderecoPessoa> builder)
        {
            builder.HasKey(ep => ep.Id);

            builder
                .HasOne(ep => ep.Pessoa);

            builder
                .HasOne(ep => ep.Endereco);

            builder.ToTable("EnderecoPessoa");
        }
    }
}
