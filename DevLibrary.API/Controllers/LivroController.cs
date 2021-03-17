using DevLibrary.Application.InputModels.Livro;
using DevLibrary.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevLibrary.API.Controllers
{
    [Route("api/livros")]
    public class LivroController : ControllerBase
    {
        private readonly ILivro _livro;
        public LivroController(ILivro livro)
        {
            _livro = livro;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var livros = _livro.GetAll(query);

            return Ok(livros);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var livro = _livro.GetById(id);

            if (livro == null)
            {
                return Ok("Livro não encontrado");
            }

            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateLivroInputModel inputModel)
        {
            var id = _livro.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateLivroInputModel inputModel)
        {
            _livro.Update(inputModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var livro = _livro.Delete(id);
            if (livro == null)
            {
                return Ok("Livro não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Livro removido com sucesso!!!");
        }
    }
}
