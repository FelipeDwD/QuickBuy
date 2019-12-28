using Dwd.Lab.Dominio.Contratos;

using Dwd.Lab.Dominio.ObjetoDeValor;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class FormaPagamentoController : Controller
    {
        private readonly IFormaPagamentoRepositorio _formaPagamentoRepositorio;

        public FormaPagamentoController(IFormaPagamentoRepositorio formaPagamentoRepositorio)
        {
            this._formaPagamentoRepositorio = formaPagamentoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var formaspagamento = this._formaPagamentoRepositorio.RetornarTodos();
                return Ok(formaspagamento);
            }           
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] FormaPagamento formaPagamento)
        {
            try
            {                
                this._formaPagamentoRepositorio.Adicionar(formaPagamento);
                return Created("api/Controller", formaPagamento);
            }            
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
