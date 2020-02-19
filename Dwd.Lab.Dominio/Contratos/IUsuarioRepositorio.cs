

using Dwd.Lab.Dominio.Entidades;

namespace Dwd.Lab.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario GetByCredenciais(string email, string senha);
        bool VerificarEmail(string email);
        bool VerificarEmail(int id, string email);
        bool VerificarCpf(string cpf);
        bool VerificarCpf(int id, string cpf);
        bool Ativo(string Cpf);
       
    }
}
