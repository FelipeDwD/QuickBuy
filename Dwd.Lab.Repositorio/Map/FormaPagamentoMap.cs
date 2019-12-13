using Dwd.Lab.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Repositorio.Map
{
    class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            //Padrão Fluent

            builder.HasKey(fp => fp.Id);

            builder
                .Property(fp => fp.Nome)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar");

            builder
                .Property(fp => fp.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.ToTable("FormaPagamento");
        }
    }
}
