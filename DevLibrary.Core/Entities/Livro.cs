using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeDeEstoque { get; set; }
        public DateTime DataPublicacao { get; set; }
        public ELivro LivroStatus { get; set; }        
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public List<Locacao> Locacoes { get; private set; }
    }
}
