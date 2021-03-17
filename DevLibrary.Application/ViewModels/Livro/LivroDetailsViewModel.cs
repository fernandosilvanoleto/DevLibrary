using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels.Livro
{
    public class LivroDetailsViewModel
    {
        public LivroDetailsViewModel(int id, string nome, string descricao, int quantidadeDeEstoque, DateTime dataPublicacao, ELivro livroStatus, string categoria)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            QuantidadeDeEstoque = quantidadeDeEstoque;
            DataPublicacao = dataPublicacao;
            LivroStatus = Enum.GetName(typeof(ELivro), livroStatus);
            Categoria = categoria;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int QuantidadeDeEstoque { get; private set; }
        public DateTime DataPublicacao { get; private set; }
        public string LivroStatus { get; private set; }
        public string Categoria { get; private set; }
    }
}
