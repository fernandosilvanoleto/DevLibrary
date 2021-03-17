using DevLibrary.Core.Enums;
using System;

namespace DevLibrary.Application.ViewModels.Locacao
{
    public class LocacaoViewModel
    {
        public LocacaoViewModel(int quantidadeLocacaoLivro, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista)
        {
            QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            LocacaoStatus = locacaoStatus;
            DataLocacao = dataLocacao;
            DataEntregaPrevista = dataEntregaPrevista;
        }

        public int QuantidadeLocacaoLivro { get; private set; }
        public ELocacao LocacaoStatus { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataEntregaPrevista { get; private set; }
    }
}
