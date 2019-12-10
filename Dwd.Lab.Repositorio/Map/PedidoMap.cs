using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map

{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //Padrão Fluent

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .HasOne(p => p.Endereco)
                .WithMany(e => e.Pedidos)
                .HasForeignKey(p => p.EnderecoId);

            builder
                .HasOne(p => p.FormaPagamento)
                .WithMany(fp => fp.Pedidos)
                .HasForeignKey(p => p.FormaPagamentoId);

            builder
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Pedidos)
                .HasForeignKey(p => p.UsuarioId);

          

        }
    }
}
