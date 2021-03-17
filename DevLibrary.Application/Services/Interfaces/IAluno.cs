using DevLibrary.Application.InputModels.Aluno;
using DevLibrary.Application.ViewModels.Aluno;
using System.Collections.Generic;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface IAluno
    {
        AlunoDetailsViewModel GetById(int id);
        List<AlunoViewModel> GetAll(string query);
        int Create(CreateAlunoInputModel inputModel); // RETORNAR O ID CADASTRADO        
        void Update(UpdateAlunoInputModel inputModel);
        int? Active(int id);
        int? Suspended(int id);
        int? Reactivate(int id);
        int? Lock(int id);
        int? Delete(int id);
    }
}
