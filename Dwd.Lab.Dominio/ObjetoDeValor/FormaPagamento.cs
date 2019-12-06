using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Enumeradores;

namespace Dwd.Lab.Dominio.ObjetoDeValor
{
    public class FormaPagamento : IFormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

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
