﻿using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Padrão fluent

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(25);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Cpf)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(u => u.DataCadastro)
                .IsRequired();

            builder
                .Property(u => u.Imagem)
                .HasMaxLength(70);

            builder
                .Property(u => u.Sexo)
                .IsRequired()
                .HasMaxLength(1);


            builder.ToTable("Usuario");

        }
    }
}
