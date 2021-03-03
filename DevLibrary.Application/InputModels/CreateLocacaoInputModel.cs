using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels
{
    public class CreateLocacaoInputModel
    {
        public string Observacao { get; private set; }
        public int QuantidadeLocacaoLivro { get; set; }
        public float ValorMultaLivroAtual { get; set; }
        public DateTime DataEntregaPrevista { get; private set; }
        public int IdRegistroATA { get; set; }
        public int IdLivro { get; set; }
    }
}
