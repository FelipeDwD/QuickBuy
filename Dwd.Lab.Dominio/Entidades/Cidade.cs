using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Cidade
    {
        
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
