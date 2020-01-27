using System.Collections;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public virtual ICollection<ImagemProduto> Imagens { get; set; }
    }
}
