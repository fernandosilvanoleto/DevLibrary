using DevLibrary.Application.InputModels.Locacao;
using DevLibrary.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevLibrary.API.Controllers
{
    [Route("api/locacoes")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacao _locacao;
        public LocacaoController(ILocacao locacao)
        {
            _locacao = locacao;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var locacoes = _locacao.GetAll(query);

            return Ok(locacoes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var locacao = _locacao.GetById(id);

            if (locacao == null)
            {
                return Ok("Locação não encontrada!!!");
            }

            return Ok(locacao);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateLocacaoInputModel createLocacao)
        {
            // CADASTRAR UMA LOCAÇÃO
           var id = _locacao.Create(createLocacao);

            return CreatedAtAction(nameof(GetById), new { id = id }, createLocacao);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateLocacaoInputModel updateLocacao)
        {
            _locacao.Update(updateLocacao);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _locacao.Delete(id);

            return Ok();
        }

    }
}
