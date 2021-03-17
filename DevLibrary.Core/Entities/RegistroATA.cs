using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevLibrary.Core.Entities
{
    public class RegistroATA
    {
        public RegistroATA(int matricula, string termo, int idAluno)
        {
            Matricula = matricula;
            Termo = termo;
            IdAluno = idAluno;

            DataRegistro = DateTime.Now;            
            Situacao = ERegistroATA.Análise;

            Locacoes = new List<Locacao>();
        }

        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Termo { get; set; }
        public int? QuantidadeSuspensaoRegistro { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime? DataSuspensao { get; set; }
        public ERegistroATA Situacao { get; set; }
        public int IdAluno { get; set; }
        public Alunos Aluno { get; set; }
        public List<Locacao> Locacoes { get; private set; }

        public void Active()
        {
            if (Situacao == ERegistroATA.Análise)
            {
                Situacao = ERegistroATA.Ativo;
            }
        }

        public void Suspended()
        {
            if (Situacao == ERegistroATA.Ativo)
            {
                Situacao = ERegistroATA.Suspenso;
                QuantidadeSuspensaoRegistro++;
                DataSuspensao = DateTime.Now;
            }
        }

        public void Reactivate()
        {
            if (Situacao == ERegistroATA.Suspenso)
            {
                Situacao = ERegistroATA.Ativo;
            }
        }

        public void Cancel()
        {
            if (Situacao == ERegistroATA.Ativo || Situacao == ERegistroATA.Suspenso)
            {
                Situacao = ERegistroATA.Excluído;
            }
        }

        public void Update(string termo)
        {
            this.Termo = termo;
        }

    }
}
