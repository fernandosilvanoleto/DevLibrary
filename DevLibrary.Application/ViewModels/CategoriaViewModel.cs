using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}
