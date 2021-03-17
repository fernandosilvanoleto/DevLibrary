using DevLibrary.Application.InputModels.Categoria;
using DevLibrary.Application.ViewModels.Categoria;
using System.Collections.Generic;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface ICategoria
    {
        List<CategoriaViewModel> GetAll(string query);
        CategoriaDetailsViewModel GetById(int id);
        int Create(CreateCategoriaInputModel inputModel);
    }
}
