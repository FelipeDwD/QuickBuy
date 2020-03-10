using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Repositorio.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            //Padrão Fluent

            
            builder
                .Property(f => f.RazaoSocialNome)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(f => f.DataNascimento)
                .IsRequired();

            builder
                .Property(f => f.RepresentanteComercialNome)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .HasMany(f => f.Telefones);

            builder
                .ToTable("Fornecedor");


        }
    }
}
