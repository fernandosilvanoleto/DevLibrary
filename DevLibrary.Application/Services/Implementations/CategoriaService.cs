using DevLibrary.Application.InputModels.Categoria;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Application.ViewModels.Categoria;
using DevLibrary.Core.Entities;
using DevLibrary.Infra.Persistence.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevLibrary.Application.Services.Implementations
{
    public class CategoriaService : ICategoria
    {
        private readonly DevLibraryDbContext _dbContext;
        public CategoriaService(DevLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateCategoriaInputModel inputModel)
        {
            var categoria = new Categoria(inputModel.Descricao);

            _dbContext.Categoria.Add(categoria);
            _dbContext.SaveChanges();

            return categoria.Id;
        }

        public List<CategoriaViewModel> GetAll(string query)
        {
            var categorias = _dbContext.Categoria;

            var categoriaViewModel = categorias
                .Select(c => new CategoriaViewModel(c.Descricao))
                .ToList();

            return categoriaViewModel;
        }

        public CategoriaDetailsViewModel GetById(int id)
        {
            var categoria = _dbContext.Categoria.SingleOrDefault(c => c.Id == id);

            var categoriaDetailsViewModel = new CategoriaDetailsViewModel(
                    categoria.Id,
                    categoria.Descricao
                );

            return categoriaDetailsViewModel;
        }
    }
}
