using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class PessoaJuridicaRepositorio : BaseRepositorio<PessoaJuridica>, IPessoaJuridicaRepositorio
    {
        public PessoaJuridicaRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
