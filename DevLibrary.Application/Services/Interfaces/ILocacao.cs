using DevLibrary.Application.InputModels.Locacao;
using DevLibrary.Application.ViewModels.Locacao;
using System.Collections.Generic;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface ILocacao
    {
        List<LocacaoViewModel> GetAll(string query);
        LocacaoDetailsViewModel GetById(int id);
        int Create(CreateLocacaoInputModel inputModel); // RETORNAR O ID CADASTRADO        
        void Update(UpdateLocacaoInputModel inputModel);
        void Devolution(UpdateLocacaoDevolutionInputModel inputModel);
        void Delete(int id);
    }
}
