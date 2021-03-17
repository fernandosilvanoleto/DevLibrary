using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class Livro
    {
        public Livro(string nome, string descricao, int quantidadeDeEstoque, DateTime dataPublicacao, int idCategoria)
        {
            Nome = nome;
            Descricao = descricao;
            QuantidadeDeEstoque = quantidadeDeEstoque;
            DataPublicacao = dataPublicacao;
            LivroStatus = ELivro.Disponivel;
            IdCategoria = idCategoria;

            Locacoes = new List<Locacao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeDeEstoque { get; set; }
        public DateTime DataPublicacao { get; set; }
        public ELivro LivroStatus { get; set; }        
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public List<Locacao> Locacoes { get; private set; }

        public void Update(string descricao, int quantidaDeEstoque)
        {
            this.Descricao = descricao;
            this.QuantidadeDeEstoque = quantidaDeEstoque;
        }

        public void Cancel()
        {
            if (LivroStatus == ELivro.Disponivel || LivroStatus == ELivro.Indisponivel)
            {
                LivroStatus = ELivro.Removido;
            }
        }
    }
}
