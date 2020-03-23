using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class RelacaoTipoRepositorio : BaseRepositorio<RelacaoTipo>, IRelacaoTipoRepositorio
    {
        public RelacaoTipoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
