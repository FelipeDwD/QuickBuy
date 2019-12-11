using Dwd.Lab.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Pedido : Entidade
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

        protected override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItemsPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem item de pedido.");

            if (DataPrevisaoEntrega < DataPedido)
                AdicionarCritica("Datas inválidas: data de entrega deve ser posterior a data do pedido.");

            if (EnderecoId == 0)
                AdicionarCritica("Não foi identificado a referência do endereço.");

            if (UsuarioId == 0)
                AdicionarCritica("Não foi identificao a referência do usuário.");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Não foi informado a forma de pagamento.");
        }
    }
}
