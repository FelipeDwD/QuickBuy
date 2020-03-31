using Dwd.Lab.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Dominio.Contratos
{
    public interface ICidadeRepositorio : IBaseRepositorio<Cidade>
    {
        List<Cidade> GetSelectListByIdEstado(int estadoId);
    }
}
