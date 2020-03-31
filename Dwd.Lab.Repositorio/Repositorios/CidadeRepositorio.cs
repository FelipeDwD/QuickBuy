using System.Collections.Generic;
using System.Linq;
using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class CidadeRepositorio : BaseRepositorio<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }

        public List<Cidade> GetSelectListByIdEstado(int estadoId)
        {
            var items = LabDataContext
                        .Cidade
                        .Where(x => x.EstadoId == estadoId)
                        .AsNoTracking()
                        .ToList();

            return items;
        }
    }
}
