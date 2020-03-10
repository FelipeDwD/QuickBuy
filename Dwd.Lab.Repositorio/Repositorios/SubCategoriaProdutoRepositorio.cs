using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class SubCategoriaProdutoRepositorio : BaseRepositorio<SubCategoriaProduto>, ISubCategoriaProduto
    {
        public SubCategoriaProdutoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
