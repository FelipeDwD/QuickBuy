using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class CidadeController : Controller
    {
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public CidadeController(ICidadeRepositorio cidadeRepositorio)
        {
            this._cidadeRepositorio = cidadeRepositorio;
        }

        [HttpPost]
        public IActionResult Save([FromBody] List<Cidade> cidades)
        {
            try
            {
                foreach (Cidade cidade in cidades)
                {
                    this._cidadeRepositorio.Adicionar(cidade);
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }
    }
}
