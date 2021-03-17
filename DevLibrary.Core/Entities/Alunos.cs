using DevLibrary.Core.Enums;
using System;
using System.Collections.Generic;

namespace DevLibrary.Core.Entities
{
    public class Alunos
    {
        public Alunos(string nomeCompleto, string email, DateTime? dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Email = email;

            DataCadastro = DateTime.Now;

            AlunoAtivo = EAlunos.Ativo;

            Matricula = new List<RegistroATA>();
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string? Foto { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public List<RegistroATA> Matricula { get; private set; }
        public EAlunos AlunoAtivo { get; private set; }

        public void Active()
        {
            if (AlunoAtivo == EAlunos.Análise)
            {
                AlunoAtivo = EAlunos.Ativo;
            }
        }

        public void Suspended()
        {
            if (AlunoAtivo == EAlunos.Ativo)
            {
                AlunoAtivo = EAlunos.Suspenso;
            }
        }

        public void Reactivate()
        {
            if (AlunoAtivo == EAlunos.Suspenso)
            {
                AlunoAtivo = EAlunos.Ativo;
            }
        }

        public void Lock()
        {
            if (AlunoAtivo == EAlunos.Ativo || AlunoAtivo == EAlunos.Suspenso)
            {
                AlunoAtivo = EAlunos.Trancado;
            }
        }

        public void Delete()
        {
            if (AlunoAtivo == EAlunos.Ativo || AlunoAtivo == EAlunos.Suspenso || AlunoAtivo == EAlunos.Trancado)
            {
                AlunoAtivo = EAlunos.Excluído;
            }
        }

        public void Update(string email, string foto)
        {
            this.Email = email;
            this.Foto = foto;
        }
    }
}
