using Dwd.Lab.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwd.Lab.Repositorio.Map
{
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            //Padrão fluent

            builder.HasKey(ip => ip.Id);

            builder
                .Property(ip => ip.Quantidade)
                .HasMaxLength(4);

            builder
                .Property(ip => ip.ProdutoId)
                .HasMaxLength(5);

            builder
                .HasOne(ip => ip.Pedido)
                .WithMany(ip => ip.ItemsPedido)
                .HasForeignKey(ip => ip.PedidoId);

            builder.ToTable("ItemPedido");
        }
    }
}
