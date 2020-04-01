using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Web.ViewModel;
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

       [HttpPost]
       public ActionResult Save([FromBody] UsuarioCadastroViewModal usuarioCadastroViewModal)
         {
            try
            {
                bool validaSenha = usuarioCadastroViewModal.Senha == usuarioCadastroViewModal.SenhaEspelho;

                if (validaSenha)
                {
                    Usuario usuario = new Usuario();

                    usuario.Id = usuarioCadastroViewModal.Id;
                    usuario.Senha = usuarioCadastroViewModal.Senha;
                    usuario.Email = usuarioCadastroViewModal.Email;
                    usuario.Imagem = usuarioCadastroViewModal.Imagem;
                    usuario.DataCadastro = DateTime.Now;
                    usuario.Ativo = true;

                    return Ok();
                }
                else
                {
                    return BadRequest("Senhas não correspondem!");
                }

                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }
    }

}
