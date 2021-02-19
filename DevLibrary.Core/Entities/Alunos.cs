using DevLibrary.Core.Enums;
using System;

namespace DevLibrary.Core.Entities
{
    public class Alunos
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public DateTime DataCadastro { get; set; }
        public EAlunos AlunoAtivo { get; set; }
    }
}
