using DevLibrary.Core.Enums;
using System;

namespace DevLibrary.Application.InputModels.Livro
{
    public class CreateLivroInputModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeDeEstoque { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int IdCategoria { get; set; }
    }
}
