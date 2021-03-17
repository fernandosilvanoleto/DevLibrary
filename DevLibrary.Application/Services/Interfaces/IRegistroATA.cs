using DevLibrary.Application.InputModels.RegistroATA;
using DevLibrary.Application.ViewModels.RegistroATA;
using System.Collections.Generic;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface IRegistroATA
    {
        RegistroDetailsViewModel GetById(int id);
        List<RegistroATAViewModel> GetAll(string query);
        int Create(CreateRegistroATAInputModel inputModel); // RETORNAR O ID CADASTRADO        
        void Update(UpdateRegistroATAInputModel inputModel);
        int? Active(int id);
        int? Suspended(int id);
        int? Reactivate(int id);
        int? Delete(int id);
    }
}
