using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            //Padrão fluent

            builder.HasKey(pf => pf.Id);

            builder
                .Property(pf => pf.Nome)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(pf => pf.Sobrenome)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(pf => pf.Sexo)
                .IsRequired()
                .HasMaxLength(1);

            builder
                .Property(pf => pf.Cpf);

            builder
                .Property(pf => pf.DataNascimento)
                .IsRequired();

            builder
                .HasOne(pf => pf.Pessoa);

            builder.ToTable("PessoaFisica");           
                
        }
    }
}
