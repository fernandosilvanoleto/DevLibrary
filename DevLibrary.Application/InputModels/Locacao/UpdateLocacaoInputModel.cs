using DevLibrary.Core.Enums;
using System;

namespace DevLibrary.Application.InputModels.Locacao
{
    public class UpdateLocacaoInputModel
    {
        //public UpdateLocacaoInputModel(string observacao, int quantidadeLocacaoLivro, float valorMultaLivroAtual, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista, DateTime? dataEntregaUsuario, decimal? valorMulta)
        //{           
        //    Observacao = observacao;
        //    QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
        //    ValorMultaLivroAtual = valorMultaLivroAtual;
        //    LocacaoStatus = locacaoStatus;
        //    DataLocacao = dataLocacao;
        //    DataEntregaPrevista = dataEntregaPrevista;
        //    DataEntregaUsuario = dataEntregaUsuario;
        //    ValorMulta = valorMulta;
        //}
        public int Id { get; set; }
        public string Observacao { get; set; }
        public int QuantidadeLocacaoLivro { get; set; }
        public float ValorMultaLivroAtual { get; set; }
        public ELocacao LocacaoStatus { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public DateTime? DataEntregaUsuario { get; set; }
        public decimal? ValorMulta { get; set; }
    }
}
