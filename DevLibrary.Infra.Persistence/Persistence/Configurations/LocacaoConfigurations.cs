using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevLibrary.Infrastructure.Persistence.Configurations
{
    public class LocacaoConfigurations : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder
                .HasKey(l => l.Id); // DEFININDO CHAVE PRIMÁRIA

            // AQUI É REPRESENTADO O RELACIONAMENTO N PARA N ENTRE "RegistroATA" E "Livro"

            builder
                .HasOne(locacao => locacao.RegistroATA) // UMA LOCAÇÃO VAI TER APENAS UM REGISTRO POR VEZ REGISTRADO => ATRIBUTO ESTÁ EM "Locacao"
                .WithMany(registroata => registroata.Locacoes) // UM RegistroATA PODE TER VÁRIAS Locações => ATRIBUTO ESTÁ EM "RegistroATA"
                .HasForeignKey(locacao => locacao.IdRegistroATA) // É O FK DE REGISTRO EM "Locacao"
                .OnDelete(DeleteBehavior.Restrict); // SEMPRE PREFERE O RESTRICT

            builder
                .HasOne(locacao => locacao.Livro) // UMA LOCAÇÃO VAI TER APENAS UM LIVRO POR VEZ REGISTRADO => ATRIBUTO ESTÁ EM "Locacao"
                .WithMany(livro => livro.Locacoes) // UM Livro PODE TER VÁRIAS Locações => ATRIBUTO ESTÁ EM "Livro"
                .HasForeignKey(locacao => locacao.IdLivro) // É O FK DE REGISTRO EM "Locacao"
                .OnDelete(DeleteBehavior.Restrict); // SEMPRE PREFERE O RESTRICT
        }
    }
}
