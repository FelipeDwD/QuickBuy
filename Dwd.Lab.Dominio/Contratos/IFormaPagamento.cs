namespace Dwd.Lab.Dominio.Contratos
{
    public interface IFormaPagamento
    {
        int EhNaoDefinido();
        int EhBoleto();
        int EhCartaoCredito();
        int EhDeposito();

        
    }
}
