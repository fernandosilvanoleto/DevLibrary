using DevLibrary.Application.InputModels.Livro;
using DevLibrary.Application.ViewModels.Livro;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.Services.Interfaces
{
    public interface ILivro
    {
        LivroDetailsViewModel GetById(int id);
        List<LivroViewModel> GetAll(string query);
        int Create(CreateLivroInputModel inputModel); // RETORNAR O ID CADASTRADO        
        void Update(UpdateLivroInputModel inputModel);
        int? Delete(int id);
    }
}
