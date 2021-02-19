using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class Locacao
    {
        public int Id { get; set; }
        public int QuantidadeLocacaoLivro { get; set; }
        public float ValorMultaLivroAtual { get; set; }
        public ELocacao LocacaoStatus { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public int IdRegistroATA { get; set; }
        public RegistroATA RegistroATA { get; set; }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
    }
}
