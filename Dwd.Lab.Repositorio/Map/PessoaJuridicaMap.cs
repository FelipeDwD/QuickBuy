using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            //Padrão fluent

            builder.HasKey(pj => pj.Id);

            builder
                .Property(pj => pj.Cnpj)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(pj => pj.NomeRepresentante)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(pj => pj.Pessoa);

            builder.ToTable("PessoaJuridica");
        }
    }
}
