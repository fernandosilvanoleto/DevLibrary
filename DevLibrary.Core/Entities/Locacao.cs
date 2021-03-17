using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class Locacao
    {
        public Locacao(string observacao, int quantidadeLocacaoLivro, float valorMultaLivroAtual, DateTime dataEntregaPrevista, int idRegistroATA, int idLivro)
        {
            Observacao = observacao;
            QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            ValorMultaLivroAtual = valorMultaLivroAtual;

            DataLocacao = DateTime.Now;
            DataEntregaPrevista = dataEntregaPrevista;

            IdRegistroATA = idRegistroATA;
            IdLivro = idLivro;

            LocacaoStatus = ELocacao.Analise;
        }

        public int Id { get; private set; }
        public string Observacao { get; private set; }
        public int QuantidadeLocacaoLivro { get; private set; }
        public float ValorMultaLivroAtual { get; private set; }
        public ELocacao LocacaoStatus { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataEntregaPrevista { get; private set; }
        public DateTime? DataEntregaUsuario { get; private set; }
        public decimal? ValorMulta { get; private set; }
        public int IdRegistroATA { get; private set; }
        public RegistroATA RegistroATA { get; private set; }
        public int IdLivro { get; private set; }
        public Livro Livro { get; set; }

        public void Cancel()
        {
            if (LocacaoStatus == ELocacao.Alugada || LocacaoStatus == ELocacao.Registrado)
            {
                LocacaoStatus = ELocacao.Cancelada;
            }            
        }

        public void Register()
        {
            if (LocacaoStatus == ELocacao.Analise)
            {
                LocacaoStatus = ELocacao.Registrado;
            }
        }

        public void Update(string observacao, int quantidadeLocacaoLivro, float valorMultaLivroAtual, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista, DateTime? dataEntregaUsuario, decimal? valorMulta)
        {
            this.Observacao = observacao;
            this.QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            this.ValorMultaLivroAtual = valorMultaLivroAtual;
            this.LocacaoStatus = locacaoStatus;
            this.DataLocacao = dataLocacao;
            this.DataEntregaPrevista = dataEntregaPrevista;
            this.DataEntregaUsuario = dataEntregaUsuario;
            this.ValorMulta = valorMulta;

        }
    }
}
