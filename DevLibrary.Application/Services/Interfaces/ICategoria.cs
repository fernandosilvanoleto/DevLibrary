using DevLibrary.Application.InputModels;
using DevLibrary.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface ICategoria
    {
        List<CategoriaViewModel> GetAll();
        CategoriaDetailsViewModel GetById(int id);
        int Create(CreateCategoriaInputModel inputModel);
    }
}
