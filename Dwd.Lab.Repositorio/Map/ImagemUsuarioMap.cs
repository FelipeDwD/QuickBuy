using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Repositorio.Map
{
    class ImagemUsuarioMap : IEntityTypeConfiguration<ImagemUsuario>
    {
        public void Configure(EntityTypeBuilder<ImagemUsuario> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Nome)
                .IsRequired()
                .HasMaxLength(50);

            

            builder.ToTable("ImagemUsuario");
        }
    }
}
