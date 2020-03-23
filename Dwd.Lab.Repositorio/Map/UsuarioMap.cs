using Dwd.Lab.Dominio.Entidades;
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
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(45);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.DataCadastro)
                .IsRequired();

            builder
                .Property(u => u.Imagem)
                .IsRequired()
                .HasMaxLength(70);

            builder
                .Property(u => u.Ativo)
                .HasColumnType("char")
                .IsRequired();


            builder.ToTable("Usuario");

        }
    }
}
