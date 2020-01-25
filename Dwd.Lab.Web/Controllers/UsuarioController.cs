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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        
        /// <summary>
        /// Hosting Environment: Serve para obter informação sobr
        /// a pasta raiz onde a aplicação está sendo utilizada.
        /// Utilidade: É no caminho onde a aplicação está sendo executada
        /// que vamos inserir o arquivo fornecido pelo usuário
        /// </summary>
        private IHostingEnvironment _hostingEnvironment;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio, 
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment)
        {
            this._usuarioRepositorio = usuarioRepositorio;
            this._httpContextAccessor = httpContextAccessor;
            this._hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var usuarios = this._usuarioRepositorio.RetornarTodos();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioReturn = this._usuarioRepositorio.GetByCredenciais(usuario.Email, usuario.Senha);
                if (usuarioReturn != null)
                    return Ok(usuarioReturn);


                return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("adicionar")]
        public IActionResult Adicionar([FromBody] Usuario usuario)
        {
            try
            {
                this._usuarioRepositorio.Adicionar(usuario);

                return Created("api/usuario", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromBody] Usuario usuario)
        {
            try
            {
                this._usuarioRepositorio.Remover(usuario);
                return BadRequest("Deletado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("EnviarArquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                //Arquivo recebido como um todo
                var formFile = this._httpContextAccessor.HttpContext.Request.Form.Files["arquivoEnviado"];

                //Nome fo arquivo recebido
                var nomeArquivo = formFile.FileName;

                //Guarda a extensão do arquivo, último(s) caractere(s) depois do último "."
                var extensao = nomeArquivo.Split(".").Last();

                //Guarda os primeiros 10 caracteres que está em "nome"
                var arrayNomeCompacto = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray();

                //Guarda os primeiros caracteres do arquivo trocando ""(espaço) por "-"(traço), adiciona ".(extensao)".
                var novoNomeArquivo = new String(arrayNomeCompacto).Replace(" ", "-") + "." + extensao;

                //Endereço da pasta onde irá ser criado o arquivo no servidor
                var pastaArquivos = this._hostingEnvironment.WebRootPath + @"\arquivos\";

                //Guarda o novo nome completo do arquivo (Caminho + novo nome)
                var nomeCompleto = pastaArquivos + novoNomeArquivo;

                using (var streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo);
                }

                return Ok("Arquivo enviado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }    
        }
    }

}
