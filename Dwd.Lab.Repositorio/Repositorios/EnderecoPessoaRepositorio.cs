using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class EnderecoPessoaRepositorio : BaseRepositorio<EnderecoPessoa>, IEnderecoPessoaRepositorio
    {
        public EnderecoPessoaRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
