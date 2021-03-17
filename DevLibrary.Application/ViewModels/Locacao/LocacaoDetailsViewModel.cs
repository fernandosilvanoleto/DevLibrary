using DevLibrary.Core.Enums;
using System;

namespace DevLibrary.Application.ViewModels.Locacao
{
    public class LocacaoDetailsViewModel
    {
        public LocacaoDetailsViewModel(int id, int quantidadeLocacaoLivro, ELocacao locacaoStatus, DateTime dataLocacao, DateTime dataEntregaPrevista, int idRegistroATA, int idLivro, int matricula, string nomeLivro)
        {
            Id = id;
            QuantidadeLocacaoLivro = quantidadeLocacaoLivro;
            LocacaoStatus = locacaoStatus;
            DataLocacao = dataLocacao;
            DataEntregaPrevista = dataEntregaPrevista;
            IdRegistroATA = idRegistroATA;
            IdLivro = idLivro;
            Matricula = matricula;
            NomeLivro = nomeLivro;
        }

        public int Id { get; private set; }
        public int QuantidadeLocacaoLivro { get; private set; }
        public ELocacao LocacaoStatus { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataEntregaPrevista { get; private set; }
        public int IdRegistroATA { get; private set; }
        public int IdLivro { get; private set; }
        public int Matricula { get; private set; }
        public string NomeLivro { get; private set; }
    }
}
