using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class CidadeRepositorio : BaseRepositorio<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
