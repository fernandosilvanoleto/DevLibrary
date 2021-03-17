using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels.Aluno
{
    public class UpdateAlunoInputModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
    }
}
