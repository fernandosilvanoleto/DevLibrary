using DevLibrary.Application.InputModels.RegistroATA;
using DevLibrary.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevLibrary.API.Controllers
{
    [Route("api/registros")]
    public class RegistroATAController : ControllerBase
    {
        private readonly IRegistroATA _registro;
        public RegistroATAController(IRegistroATA registro)
        {
            _registro = registro;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var registroatas = _registro.GetAll(query);

            return Ok(registroatas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var registro = _registro.GetById(id);

            if (registro == null)
            {
                return Ok("Registro de ATA não encontrada!!!");
            }

            return Ok(registro);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateRegistroATAInputModel inputModel)
        {
            var id = _registro.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut]
        [Route("active/{id:int}")]
        public IActionResult Active(int id)
        {
            var registroata = _registro.Active(id);
            if (registroata == null)
            {
                return Ok("RegistroATA não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }          

            return Ok("Registra ATA ativado com sucesso!!!");
        }

        [HttpPut]
        [Route("suspended/{id:int}")]
        public IActionResult Suspended(int id)
        {
            var registroata = _registro.Suspended(id);
            if (registroata == null)
            {
                return Ok("RegistroATA não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Registra ATA suspendido com sucesso!!!");
        }

        [HttpPut]
        [Route("reactivate/{id:int}")]
        public IActionResult Reactivate(int id)
        {
            var registroata = _registro.Reactivate(id);
            if (registroata == null)
            {
                return Ok("RegistroATA não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Registra ATA reativado com sucesso!!!");
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var registroata = _registro.Delete(id);
            if (registroata == null)
            {
                return Ok("RegistroATA não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Registra ATA removido com sucesso!!!");
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateRegistroATAInputModel inputModel)
        {
            _registro.Update(inputModel);

            return Ok();
        }

    }
}
