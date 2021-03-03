
using System.Collections.Generic;

namespace DevLibrary.Core.Entities
{
    public class Categoria
    {
        public Categoria(string descricao)
        {
            Descricao = descricao;

            Livros = new List<Livro>();
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }

        public List<Livro> Livros { get; private set; } // ATRIBUTO DE NAVEGAÇÃO NECESSÁRIO PARA CRIAR UMA RELAÇÃO DE 1 PARA N COM A TABELA "Livro"
    }
}
