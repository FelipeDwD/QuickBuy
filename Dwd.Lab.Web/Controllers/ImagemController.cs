using Dwd.Lab.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ImagemController : Controller
    {
        private readonly IImagem _imagem;

        public ImagemController(IImagem imagem)
        {
            this._imagem = imagem;
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                var nome = this._imagem.EnviarParaServidor();

                return Json(nome);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
