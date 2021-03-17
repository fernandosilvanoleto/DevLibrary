using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Application.InputModels.RegistroATA
{
    public class CreateRegistroATAInputModel
    {
        public int Matricula { get; set; }
        public string Termo { get; set; }
        public int IdAluno { get; set; }
    }
}
