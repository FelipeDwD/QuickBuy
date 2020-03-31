using System.Collections.Generic;

namespace Dwd.Lab.Web.ViewModel
{
    public class EstadoViewModel
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<CidadeViewModel> Cidades { get; set; }
    }
}
