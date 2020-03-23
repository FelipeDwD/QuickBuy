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

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            this._usuarioRepositorio = usuarioRepositorio;
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

        [HttpGet("getbyid")]
        public IActionResult GetById([FromBody] Usuario usuario)
        {
            try
            {
                var user = this._usuarioRepositorio.RetornarPorId(usuario.Id);

                if (user != null)
                    return Ok(usuario);

                return BadRequest("Usuário não encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] Usuario usuario)
        {
            try
            {




                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Método para laboratório, o mesmo insere vários usuários ao mesmo tempo.
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        [HttpPost("adicionarN")]
        public IActionResult Adicionar([FromBody] List<Usuario> usuarios)
        {
            try
            {
                foreach (Usuario u in usuarios)
                {
                    u.Ativo = true;
                    
                    this._usuarioRepositorio.Adicionar(u);
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("adicionar")]
        public IActionResult Adicionar([FromBody] Usuario usuario)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpPost("alterarStatus")]
        public IActionResult AlterarStatus([FromBody] Usuario usuario)
        {
            try
            {
                bool ativo = usuario.Ativo ? usuario.Ativo = false : usuario.Ativo = true;

                this._usuarioRepositorio.Atualizar(usuario);

                return Ok();
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

        [HttpPut]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }

}
