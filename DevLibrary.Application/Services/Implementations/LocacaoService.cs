using DevLibrary.Application.InputModels.Locacao;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Application.ViewModels.Locacao;
using DevLibrary.Core.Entities;
using DevLibrary.Infra.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DevLibrary.Application.Services.Implementations
{
    public class LocacaoService : ILocacao
    {
        private readonly DevLibraryDbContext _dbContext;
        public LocacaoService(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CreateLocacaoInputModel inputModel)
        {
            var locacao = new Locacao(inputModel.Observacao, inputModel.QuantidadeLocacaoLivro, inputModel.ValorMultaLivroAtual, inputModel.DataEntregaPrevista, inputModel.IdRegistroATA, inputModel.IdLivro);

            _dbContext.Locacao.Add(locacao);
            _dbContext.SaveChanges();

            return locacao.Id;
        }

        public void Delete(int id)
        {
            var locacao = _dbContext.Locacao.SingleOrDefault(l => l.Id == id);

            locacao.Cancel();
            _dbContext.SaveChanges();
        }

        public void Register(int id)
        {
            var locacao = _dbContext.Locacao.SingleOrDefault(l => l.Id == id);

            locacao.Register();
            _dbContext.SaveChanges();
        }

        public void Devolution(UpdateLocacaoDevolutionInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }

        public List<LocacaoViewModel> GetAll(string query)
        {
            var locacoes = _dbContext.Locacao;

            var locacaoViewModel = locacoes
                .Select(l => new LocacaoViewModel(l.QuantidadeLocacaoLivro, l.LocacaoStatus, l.DataLocacao, l.DataEntregaPrevista))
                .ToList();

            return locacaoViewModel;
        }

        public LocacaoDetailsViewModel GetById(int id)
        {
            var locacao = _dbContext.Locacao
                .Include(l => l.RegistroATA)
                .Include(l => l.Livro)
                .SingleOrDefault(l => l.Id == id);

            if (locacao == null)
            {
                return null;
            }

            var locacaoDetailsViewModel = new LocacaoDetailsViewModel(
                    locacao.Id,
                    locacao.QuantidadeLocacaoLivro,
                    locacao.LocacaoStatus,
                    locacao.DataLocacao,
                    locacao.DataEntregaPrevista,
                    locacao.IdRegistroATA,
                    locacao.IdLivro,
                    locacao.RegistroATA.Matricula,
                    locacao.Livro.Nome
                );

            return locacaoDetailsViewModel;
        }

        public void Update(UpdateLocacaoInputModel inputModel)
        {
            var locacao = _dbContext.Locacao.SingleOrDefault(l => l.Id == inputModel.Id);

            locacao.Update(inputModel.Observacao, inputModel.QuantidadeLocacaoLivro, inputModel.ValorMultaLivroAtual, inputModel.LocacaoStatus, inputModel.DataLocacao, inputModel.DataEntregaPrevista, inputModel.DataEntregaUsuario, inputModel.ValorMulta);
            _dbContext.SaveChanges();
        }
    }
}
