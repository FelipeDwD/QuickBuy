namespace Dwd.Lab.Dominio.Contratos
{
    public interface IImagem
    {
        string EnviarParaServidor();
        void RemoverDoServidor(string arquivo);
    }
}
