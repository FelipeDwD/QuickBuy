using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Dominio.Enumeradores;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        ///  Forma de pagamento pode ter nenhum ou vários pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public FormaPagamento() : base()
        {                    
        }

        public int EhBoleto()
        {
            return this.Id = (int)TipoFormaPagamentoEnum.Boleto;
        }

        public int EhCartaoCredito()
        {
            return this.Id = (int)TipoFormaPagamentoEnum.CartaoCredito;
        }

        public int EhDeposito()
        {
            return this.Id = (int)TipoFormaPagamentoEnum.Deposito;
        }

        public int EhNaoDefinido()
        {
            return this.Id = (int)TipoFormaPagamentoEnum.NaoDefinido;
        }

      
    }
}
