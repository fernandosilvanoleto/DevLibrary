
namespace DevLibrary.Application.ViewModels.Categoria
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }
    }
}
