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
    public class CategoriaProdutoController : Controller
    {
        private readonly ICategoriaProdutoRepositorio _categoriaProdutoRepositorio;

        public CategoriaProdutoController(ICategoriaProdutoRepositorio categoriaProdutoRepositorio)
        {
            this._categoriaProdutoRepositorio = categoriaProdutoRepositorio;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoriaProduto categoriaProduto)
        {
            try
            {
                this._categoriaProdutoRepositorio.Adicionar(categoriaProduto);
                return Ok(categoriaProduto);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpGet]
        public IActionResult GetSelectList()
        {
            try
            {
                var items = this._categoriaProdutoRepositorio.RetornarTodos();

                if (items != null)
                    return Ok(items);

                return BadRequest("Nenhuma categoria encontrada");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

    }
}
