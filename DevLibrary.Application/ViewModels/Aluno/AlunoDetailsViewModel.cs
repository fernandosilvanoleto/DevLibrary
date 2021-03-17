using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.ViewModels.Aluno
{
    public class AlunoDetailsViewModel
    {
        public AlunoDetailsViewModel(int id, string nomeCompleto, DateTime? dataNascimento, string email, DateTime dataCadastro, EAlunos alunoAtivo)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Email = email;
            DataCadastro = dataCadastro;
            AlunoAtivo = Enum.GetName(typeof(EAlunos), alunoAtivo);
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string AlunoAtivo { get; private set; }
    }
}
