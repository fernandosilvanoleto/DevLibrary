using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;

namespace DevLibrary.Core.Entities
{
    public class Alunos
    {
        public Alunos(string nomeCompleto, string email, string foto)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Foto = foto;
            DataCadastro = DateTime.Now;

            Matricula = new List<RegistroATA>();
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string Foto { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public List<RegistroATA> Matricula { get; private set; }
        public EAlunos AlunoAtivo { get; private set; }
    }
}
