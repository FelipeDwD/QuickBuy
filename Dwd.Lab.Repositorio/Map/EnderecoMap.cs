﻿using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Padrão fluent

            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(4);

            builder
                .Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(12);

            builder
                .HasOne(e => e.Cidade);

            builder
                .HasOne(e => e.Estado);            

            builder
                .Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(12);         

         builder.ToTable("Endereco");

        }
    }
}
