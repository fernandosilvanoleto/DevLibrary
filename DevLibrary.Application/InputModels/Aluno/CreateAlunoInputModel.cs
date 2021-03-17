using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels.Aluno
{
    public class CreateAlunoInputModel
    {
        public string NomeCompleto { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
