using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels
{
    public class UpdateLocacaoInputModel
    {
        public UpdateLocacaoInputModel(string observacao, int quantidadeLocacaoLivro, float valorMultaLivroAtual, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista, DateTime? dataEntregaUsuario, decimal? valorMulta)
        {           
            Observacao = observacao;
            QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            ValorMultaLivroAtual = valorMultaLivroAtual;
            LocacaoStatus = locacaoStatus;
            DataLocacao = dataLocacao;
            DataEntregaPrevista = dataEntregaPrevista;
            DataEntregaUsuario = dataEntregaUsuario;
            ValorMulta = valorMulta;
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
    }
}
