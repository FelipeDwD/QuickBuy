using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class ImagemUsuarioRepositorio : BaseRepositorio<ImagemUsuario>, IImagemUsuarioRepositorio
    {
        public ImagemUsuarioRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
