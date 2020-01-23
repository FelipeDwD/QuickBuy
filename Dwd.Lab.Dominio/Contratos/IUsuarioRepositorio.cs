

using Dwd.Lab.Dominio.Entidades;

namespace Dwd.Lab.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario GetByCredenciais(string email, string senha);
    }
}
