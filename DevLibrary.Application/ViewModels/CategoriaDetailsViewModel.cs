using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels
{
    public class CategoriaDetailsViewModel
    {
        public CategoriaDetailsViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
    }
}
