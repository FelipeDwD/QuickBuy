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
                var verificar = this._usuarioRepositorio.VerificarEmail(usuario.Email);

                if (!verificar)
                {
                    this._usuarioRepositorio.Adicionar(usuario);
                    return Created("api/usuario", usuario);
                }
                
                return BadRequest("Já temos um usuário com esse e-mail");
                                  
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
    }

}
