using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class CategoriaProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<SubCategoriaProduto> SubCategoriaProdutos { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
