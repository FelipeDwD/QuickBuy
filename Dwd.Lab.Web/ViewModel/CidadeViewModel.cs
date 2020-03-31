using Dwd.Lab.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.ViewModel
{
    public class CidadeViewModel
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }
    }
}
