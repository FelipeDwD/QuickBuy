using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class PessoaTipoRepositorio : BaseRepositorio<PessoaTipo>, IPessoaTipoRepositorio
    {
        public PessoaTipoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
