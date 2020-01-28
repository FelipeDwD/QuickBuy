using System;
using System.Collections.Generic;
using System.Text;

namespace Dwd.Lab.Dominio.Entidades
{
    public class ImagemProduto : Imagem
    {
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public ImagemProduto() : base (null, null)
        {

        }
    }
}
