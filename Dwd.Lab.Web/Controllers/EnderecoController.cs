using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            this._enderecoRepositorio = enderecoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var enderecos = _enderecoRepositorio.RetornarTodos();
                return Ok(enderecos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());              
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Endereco endereco)
        {
            try
            {
                _enderecoRepositorio.Adicionar(endereco);
                return Created("api/endereco", endereco);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}
