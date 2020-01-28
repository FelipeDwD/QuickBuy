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
        private readonly IImagem _imagem;

        public ImagemUsuarioController(IImagemUsuarioRepositorio imagemUsuarioRepositorio,
            IImagem imagem)
        {
            this._imagemUsuarioRepositorio = imagemUsuarioRepositorio;
            this._imagem = imagem;
        }


        [HttpPost]
        public IActionResult Post([FromBody] ImagemUsuario imagemUsuario)
        {
            try
            {
                //Envia imagem para o servidor e retorna o novo nome dela
                var imagem = this._imagem.EnviarParaServidor();

                //Atualizando o nome da imagem antes de salvar no banco
                imagemUsuario.Nome = imagem;

                //Armazena o id e o novo nome da imagem no banco de dados
                this._imagemUsuarioRepositorio.Adicionar(imagemUsuario);

                return Json(imagem);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
