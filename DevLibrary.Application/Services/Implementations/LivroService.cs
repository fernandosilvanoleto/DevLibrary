using DevLibrary.Application.InputModels.Livro;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Application.ViewModels.Livro;
using DevLibrary.Core.Entities;
using DevLibrary.Infra.Persistence.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DevLibrary.Application.Services.Implementations
{
    public class LivroService : ILivro
    {
        private readonly DevLibraryDbContext _dbContext;
        public LivroService(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CreateLivroInputModel inputModel)
        {
            var livro = new Livro(inputModel.Nome, inputModel.Descricao, inputModel.QuantidadeDeEstoque, inputModel.DataPublicacao, inputModel.IdCategoria);

            _dbContext.Livro.Add(livro);
            _dbContext.SaveChanges();

            return livro.Id;
        }

        public int? Delete(int id)
        {
            var livro = _dbContext.Livro.SingleOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return null;
            }

            livro.Cancel();
            _dbContext.SaveChanges();

            return livro.Id;
        }

        public List<LivroViewModel> GetAll(string query)
        {
            var livros = _dbContext.Livro;

            var categoriaViewModel = livros
                .Include(l => l.Categoria)
                .Select(l => new LivroViewModel(l.Id, l.Nome, l.Descricao, l.QuantidadeDeEstoque, l.DataPublicacao, l.LivroStatus, l.Categoria.Descricao))
                .ToList();

            return categoriaViewModel;
        }

        public LivroDetailsViewModel GetById(int id)
        {
            var livro = _dbContext.Livro
                .Include(l => l.Categoria)
                .SingleOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return null;
            }

            var livroDetailsViewModel = new LivroDetailsViewModel(
                 livro.Id,
                 livro.Nome,
                 livro.Descricao,
                 livro.QuantidadeDeEstoque,
                 livro.DataPublicacao,
                 livro.LivroStatus,
                 livro.Categoria.Descricao
              );

            return livroDetailsViewModel;
        }

        public void Update(UpdateLivroInputModel inputModel)
        {
            var livro = _dbContext.Livro.SingleOrDefault(l => l.Id == inputModel.Id);

            livro.Update(inputModel.Descricao, inputModel.QuantidadeDeEstoque);
            _dbContext.SaveChanges();
        }
    }
}
