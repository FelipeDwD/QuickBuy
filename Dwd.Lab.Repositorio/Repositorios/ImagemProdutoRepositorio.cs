using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using Dwd.Lab.Dominio.Contratos;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class ImagemProdutoRepositorio : BaseRepositorio<ImagemProduto>, IImagemProdutoRepositorio
    {
        public ImagemProdutoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
