using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class TelefoneRepositorio : BaseRepositorio<Telefone>, ITelefoneRepositorio
    {
        public TelefoneRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
