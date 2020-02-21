using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class PessoaRepositorio : BaseRepositorio<Pessoa>, IPessoaRepositorio
    {
        public PessoaRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
