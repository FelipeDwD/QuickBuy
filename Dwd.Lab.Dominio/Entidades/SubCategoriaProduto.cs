using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class SubCategoriaProduto
    {
        public int Id { get; set; }
        public int CategoriaProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual CategoriaProduto CategoriaProduto { get; set; }
        public virtual ICollection<Produto>  Produtos { get; set; }


    }
}
