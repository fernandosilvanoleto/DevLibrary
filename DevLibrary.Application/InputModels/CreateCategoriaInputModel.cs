using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels
{
    public class CreateCategoriaInputModel
    {
        public CreateCategoriaInputModel(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}
