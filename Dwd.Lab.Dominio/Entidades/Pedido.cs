using Dwd.Lab.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        ///  Pedido deve ter pelo menos um ou vários itens
        /// </summary>
        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }
    }    
}
