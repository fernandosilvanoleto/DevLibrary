using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels.Livro
{
    public class UpdateLivroInputModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeDeEstoque { get; set; }
    }
}
