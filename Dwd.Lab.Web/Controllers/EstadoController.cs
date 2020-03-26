using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class EstadoController : Controller
    {
        private readonly IEstadoRepositorio _estadoRepositorio;

        public EstadoController(IEstadoRepositorio estadoRepositorio)
        {
            this._estadoRepositorio = estadoRepositorio;
        }

        [HttpPost]
        public IActionResult Save([FromBody] List<Estado> estados)
        {
            try
            {
                foreach (Estado estado in estados)
                {
                    this._estadoRepositorio.Adicionar(estado);
                }

                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message.ToString());
            }


        }

    }
}
