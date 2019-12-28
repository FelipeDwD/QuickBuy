namespace Dwd.Lab.Dominio.Entidades
{
    public class ItemPedido 
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }

        public int PedidoId { get; set; }

        public virtual Pedido Pedido { get; set; }

          
    }
}
