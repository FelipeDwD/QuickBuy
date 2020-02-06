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
                {
                    var ativo = this._usuarioRepositorio.Ativo(usuarioReturn.Cpf);     
                    if(ativo)
                    return Ok(usuarioReturn);

                    return BadRequest("Usuário bloqueado.");
                }
                    


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
                var verificarEmail = this._usuarioRepositorio.VerificarEmail(usuario.Email);
                var verificarCpf = this._usuarioRepositorio.VerificarCpf(usuario.Cpf);

                if (!verificarEmail)
                {
                    if (!verificarCpf)
                    {
                        usuario.DataCadastro = DateTime.Now;
                        usuario.Ativo = true;
                        this._usuarioRepositorio.Adicionar(usuario);
                        return Created("api/usuario", usuario);
                    }
                    else
                    {
                        return BadRequest("Já temos um usuário com esse CPF.");   
                    }                    
                }
                else
                {
                    return BadRequest("Já temos um usuário com esse e-mail");
                }               

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
                this._usuarioRepositorio.Atualizar(usuario);
                return Created("api/usuario", usuario);               

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }

}
