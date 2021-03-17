
namespace DevLibrary.Application.ViewModels.Categoria
{
    public class CategoriaDetailsViewModel
    {
        public CategoriaDetailsViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
    }
}
