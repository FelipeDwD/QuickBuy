using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class PessoaFisicaRepositorio : BaseRepositorio<PessoaFisica>, IPessoaFisicaRepositorio
    {
        public PessoaFisicaRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
