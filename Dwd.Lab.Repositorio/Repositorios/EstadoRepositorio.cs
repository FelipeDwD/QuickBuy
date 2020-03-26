using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class EstadoRepositorio : BaseRepositorio<Estado>, IEstadoRepositorio
    {
        public EstadoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
