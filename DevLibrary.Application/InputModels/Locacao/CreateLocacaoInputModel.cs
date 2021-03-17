using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels.Locacao
{
    public class CreateLocacaoInputModel
    {
        public string Observacao { get; set; }
        public int QuantidadeLocacaoLivro { get; set; }
        public float ValorMultaLivroAtual { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public int IdRegistroATA { get; set; }
        public int IdLivro { get; set; }
    }
}
