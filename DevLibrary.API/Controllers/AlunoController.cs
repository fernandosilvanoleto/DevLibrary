using DevLibrary.Application.InputModels.Aluno;
using DevLibrary.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevLibrary.API.Controllers
{
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly IAluno _aluno;
        public AlunoController(IAluno aluno)
        {
            _aluno = aluno;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var alunos = _aluno.GetAll(query);

            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _aluno.GetById(id);

            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nossa base. Por favor, verifique novamente");
            }

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAlunoInputModel inputModel)
        {
            var id = _aluno.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut]
        [Route("active/{id:int}")]
        public IActionResult Active(int id)
        {
            var aluno = _aluno.Active(id);
            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Aluno ativado com sucesso!!!");
        }

        [HttpPut]
        [Route("suspended/{id:int}")]
        public IActionResult Suspended(int id)
        {
            var aluno = _aluno.Suspended(id);
            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Aluno suspenso com sucesso!!!");
        }

        [HttpPut]
        [Route("reactivate/{id:int}")]
        public IActionResult Reactivate(int id)
        {
            var aluno = _aluno.Reactivate(id);
            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Aluno reativado com sucesso!!!");
        }

        [HttpPut]
        [Route("lock/{id:int}")]
        public IActionResult Lock(int id)
        {
            var aluno = _aluno.Lock(id);
            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Aluno bloqueado com sucesso!!!");
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var aluno = _aluno.Delete(id);
            if (aluno == null)
            {
                return Ok("Aluno não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
            }

            return Ok("Aluno removido com sucesso!!!");
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateAlunoInputModel inputModel)
        {
            _aluno.Update(inputModel);

            return Ok();
        }
    }
}
