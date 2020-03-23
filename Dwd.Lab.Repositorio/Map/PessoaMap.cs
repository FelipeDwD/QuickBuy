﻿using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            //Padrão fluent

            builder.HasKey(p => p.Id);           

            builder
                .Property(p => p.RazaoSocialNome)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(p => p.DataNascimento)
                .IsRequired();

            builder
                .Property(p => p.DataCadastro)
                .IsRequired();

            builder
                .Property(p => p.Imagem)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(p => p.Telefones)
                .WithOne(t => t.Pessoa)
                .HasForeignKey(t => t.PessoaId);

            builder
                .HasOne(p => p.Usuario);

           

            builder.ToTable("Pessoa");
        }
    }
}
