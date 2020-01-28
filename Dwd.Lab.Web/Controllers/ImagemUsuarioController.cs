using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ImagemUsuarioController : Controller
    {
        private readonly IImagemUsuarioRepositorio _imagemUsuarioRepositorio;       
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IImagem _imagem;

        public ImagemUsuarioController(IImagemUsuarioRepositorio imagemUsuarioRepositorio, IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment, IImagem imagem)
        {
            this._imagemUsuarioRepositorio = imagemUsuarioRepositorio;
            this._httpContextAccessor = httpContextAccessor;
            this._hostingEnvironment = hostingEnvironment;
            this._imagem = imagem;
        }


        [HttpPost]
        public IActionResult Post(ImagemUsuario imagemUsuario)
        {
            try
            {               
               this._imagemUsuarioRepositorio.Adicionar(imagemUsuario);

                return Created("api/imagemusuario", imagemUsuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("enviararquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                //Envia imagem para o servidor e retorna o novo nome dela
                var imagem = this._imagem.EnviarParaServidor();

                ImagemUsuario imagemUsuario = new ImagemUsuario();

                imagemUsuario.Nome = imagem;
               
                

                this.Post(imagemUsuario);


                return Json(imagem);              
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
