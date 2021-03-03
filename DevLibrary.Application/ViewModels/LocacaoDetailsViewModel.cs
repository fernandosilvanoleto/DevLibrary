using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels
{
    public class LocacaoDetailsViewModel
    {
        public LocacaoDetailsViewModel(int id, int quantidadeLocacaoLivro, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista, int idRegistroATA, int idLivro)
        {
            Id = id;
            QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            LocacaoStatus = locacaoStatus;
            DataLocacao = dataLocacao;
            DataEntregaPrevista = dataEntregaPrevista;
            IdRegistroATA = idRegistroATA;
            IdLivro = idLivro;
        }

        public int Id { get; private set; }
        public int QuantidadeLocacaoLivro { get; private set; }
        public ELocacao LocacaoStatus { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataEntregaPrevista { get; private set; }
        public int IdRegistroATA { get; private set; }
        public int IdLivro { get; private set; }
    }
}
