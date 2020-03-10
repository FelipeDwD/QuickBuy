using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class FornecedorRepositorio : BaseRepositorio<Fornecedor>, IFornecedorRepositorio
    {
        public FornecedorRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
