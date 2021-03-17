using DevLibrary.Core.Enums;
using System;
using System.Linq;

namespace DevLibrary.Application.ViewModels.RegistroATA
{
    public class RegistroATAViewModel
    {
        public RegistroATAViewModel(int matricula, string termo, DateTime dataRegistro, ERegistroATA situacao, string nomeAluno)
        {
            Matricula = matricula;
            Termo = termo;
            DataRegistro = dataRegistro;
            Situacao = Enum.GetName(typeof(ERegistroATA), situacao);
            NomeAluno = nomeAluno;
        }

        public int Matricula { get; private set; }
        public string Termo { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public string Situacao { get; private set; }
        public string NomeAluno { get; private set; }
    }
}
