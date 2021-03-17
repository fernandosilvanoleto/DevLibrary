using DevLibrary.Application.InputModels.Categoria;
using DevLibrary.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace DevLibrary.API.Controllers
{
    [Route("api/categorias")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria _categoria;
        public CategoriaController(ICategoria categoria)
        {
            _categoria = categoria;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var categorias = _categoria.GetAll(query);

            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var categoria = _categoria.GetById(id);

            if (categoria == null)
            {
                return Ok("Categoria não encontrada!");
            }

            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateCategoriaInputModel inputModel)
        {
            var id = _categoria.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }
    }
}
