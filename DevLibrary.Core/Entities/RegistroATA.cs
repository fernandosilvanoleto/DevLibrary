using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class RegistroATA
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Termo { get; set; }
        public int QuantidadeSuspensaoRegistro { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataSuspensao { get; set; }
        public ERegistroATA Situacao { get; set; }
        public int IdAluno { get; set; }
        public Alunos Aluno { get; set; }
    }
}
