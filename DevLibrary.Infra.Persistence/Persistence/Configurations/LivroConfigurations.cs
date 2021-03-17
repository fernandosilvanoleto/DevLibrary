using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevLibrary.Infrastructure.Persistence.Configurations
{
    public class LivroConfigurations : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder
                 .HasKey(l => l.Id); // DEFININDO CHAVE PRIMÁRIA

            builder
                 .HasOne(livro => livro.Categoria) // UM LIVRO SOMENTE TEM UMA CATEGORIA DISPONÍVEL => ATRIBUTO "Categoria" É UM ATRIBUTO DE NAVEGAÇÃO => FAÇO NA TABELA Livro
                .WithMany(categoria => categoria.Livros) // UMA CATEGORIA PODE ESTÁ EM VÁRIOS LIVROS => FAZ RELAÇÃO COM A TABELA DE "Categoria"
                .HasForeignKey(livro => livro.IdCategoria) // REFERENCIO A CHAVE FK EM "Livro" PARA RELACIONAR COM A CATEGORIA  => FAÇO NA TABELA Livro
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasMany(livro => livro.Locacoes) // UM Livro PODE ESTAR EM MAIS DE UMA Locações => ATRIBUTO ESTÁ EM "Livro"
            //    .WithOne() // UMA Locacao VAI TER UM Livro RELACIONADO POR VEZ NA LINHA
            //    .HasForeignKey(locacao => locacao.IdLivro) // É O FK DE Livro EM "Locacao"
            //    .OnDelete(DeleteBehavior.Restrict); // SEMPRE PREFERE O RESTRICT
        }
    }
}
