using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels.RegistroATA
{
    public class RegistroDetailsViewModel
    {
        public RegistroDetailsViewModel(int id, int matricula, string termo, DateTime dataRegistro, string nomeAluno)
        {
            Id = id;
            Matricula = matricula;
            Termo = termo;
            DataRegistro = dataRegistro;
            NomeAluno = nomeAluno;
        }

        public int Id { get; private set; }
        public int Matricula { get; private set; }
        public string Termo { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public string NomeAluno { get; private set; }
    }
}
