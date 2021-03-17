using DevLibrary.Application.InputModels.Aluno;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Application.ViewModels.Aluno;
using DevLibrary.Core.Entities;
using DevLibrary.Infra.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevLibrary.Application.Services.Implementations
{
    public class AlunoService : IAluno
    {
        private readonly DevLibraryDbContext _dbContext;
        public AlunoService(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int? Active(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return null;
            }

            aluno.Active();
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public int Create(CreateAlunoInputModel inputModel)
        {
            var aluno = new Alunos(inputModel.NomeCompleto, inputModel.Email, inputModel.DataNascimento);

            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public int? Delete(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return null;
            }

            aluno.Delete();
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public List<AlunoViewModel> GetAll(string query)
        {
            var aluno = _dbContext.Alunos;

            var alunos = aluno
                .Select(a => new AlunoViewModel(a.Id, a.NomeCompleto, a.DataNascimento, a.Email, a.DataCadastro, a.AlunoAtivo))
                .ToList();

            return alunos;
        }

        public AlunoDetailsViewModel GetById(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return null;
            }

            var alunoDetailsViewModel = new AlunoDetailsViewModel(
                    aluno.Id,
                    aluno.NomeCompleto,
                    aluno.DataNascimento,
                    aluno.Email,
                    aluno.DataCadastro,
                    aluno.AlunoAtivo
                );

            return alunoDetailsViewModel;
        }

        public int? Lock(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(r => r.Id == id);

            if (aluno == null)
            {
                return null;
            }

            aluno.Lock();
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public int? Reactivate(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(r => r.Id == id);

            if (aluno == null)
            {
                return null;
            }

            aluno.Reactivate();
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public int? Suspended(int id)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(r => r.Id == id);

            if (aluno == null)
            {
                return null;
            }

            aluno.Suspended();
            _dbContext.SaveChanges();

            return aluno.Id;
        }

        public void Update(UpdateAlunoInputModel inputModel)
        {
            var aluno = _dbContext.Alunos.SingleOrDefault(r => r.Id == inputModel.Id);

            aluno.Update(inputModel.Email, inputModel.Foto);
            _dbContext.SaveChanges();
        }
    }
}
