using DevLibrary.Application.InputModels.RegistroATA;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Application.ViewModels.RegistroATA;
using DevLibrary.Core.Entities;
using DevLibrary.Infra.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DevLibrary.Application.Services.Implementations
{
    public class RegistroATAService : IRegistroATA
    {
        private readonly DevLibraryDbContext _dbContext;
        public RegistroATAService(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int? Active(int id)
        {
            var registroata = _dbContext.RegistroATA.SingleOrDefault(r => r.Id == id);

            if (registroata != null)
            {
                registroata.Active();
                _dbContext.SaveChanges();

                return registroata.Id;
            }
            else
            {
                return null;
            }          
            
        }

        public int Create(CreateRegistroATAInputModel inputModel)
        {
            var registroata = new RegistroATA(inputModel.Matricula, inputModel.Termo, inputModel.IdAluno);

            _dbContext.RegistroATA.Add(registroata);
            _dbContext.SaveChanges();

            return registroata.Id;
        }

        public int? Delete(int id)
        {
            var registroata = _dbContext.RegistroATA.SingleOrDefault(r => r.Id == id);

            if (registroata == null)
            {
                return null;
            }

            registroata.Cancel();
            _dbContext.SaveChanges();

            return registroata.Id;
        }

        public List<RegistroATAViewModel> GetAll(string query)
        {
            var registroata = _dbContext.RegistroATA;

            var registroatas = registroata
                .Include(r => r.Aluno)
                .Select(l => new RegistroATAViewModel(l.Matricula, l.Termo, l.DataRegistro, l.Situacao, l.Aluno.NomeCompleto))
                .ToList();

            return registroatas;
        }

        public RegistroDetailsViewModel GetById(int id)
        {
            var registroata = _dbContext.RegistroATA
                .Include(r => r.Aluno)
                .SingleOrDefault(r => r.Id == id);

            if (registroata == null)
            {
                return null;
            }

            var registroDetailsViewModel = new RegistroDetailsViewModel(
                   registroata.Id,
                   registroata.Matricula,
                   registroata.Termo,
                   registroata.DataRegistro,
                   registroata.Aluno.NomeCompleto
               );

            return registroDetailsViewModel;
        }

        public int? Reactivate(int id)
        {
            var registroata = _dbContext.RegistroATA.SingleOrDefault(r => r.Id == id);

            if (registroata == null)
            {
                return null;
            }

            registroata.Reactivate();
            _dbContext.SaveChanges();

            return registroata.Id;
        }

        public int? Suspended(int id)
        {
            var registroata = _dbContext.RegistroATA.SingleOrDefault(r => r.Id == id);

            if (registroata == null)
            {
                return null;
            }

            registroata.Suspended();
            _dbContext.SaveChanges();

            return registroata.Id;
        }

        public void Update(UpdateRegistroATAInputModel inputModel)
        {
            var registroata = _dbContext.RegistroATA.SingleOrDefault(r => r.Id == inputModel.Id);

            registroata.Update(inputModel.Termo);
            _dbContext.SaveChanges();
        }
        
    }
}
