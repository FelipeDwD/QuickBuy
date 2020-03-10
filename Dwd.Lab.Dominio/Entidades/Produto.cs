using System;
using System.Collections;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public int CategoriaProdutoId { get; set; }
        
        public int? SubCategoriaProdutoId { get; set; }

        public string CodigoLoja { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public virtual CategoriaProduto CategoriaProduto { get; set; }
        public virtual SubCategoriaProduto SubCategoriaProduto { get; set; }


    }
}
