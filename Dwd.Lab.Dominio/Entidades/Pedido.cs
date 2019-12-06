using Dwd.Lab.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public int EnderecoId { get; set; }
        public int UsuarioId { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        ///  Pedido deve ter pelo menos um ou vários itens
        /// </summary>
        public ICollection<ItemPedido> ItemsPedido { get; set; }
    }
}
