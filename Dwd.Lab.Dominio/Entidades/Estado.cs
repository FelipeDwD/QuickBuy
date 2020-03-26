using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string  Nome { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
