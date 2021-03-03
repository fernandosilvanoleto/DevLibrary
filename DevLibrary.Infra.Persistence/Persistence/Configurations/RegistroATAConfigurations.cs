using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DevLibrary.Infrastructure.Persistence.Configurations
{
    public class RegistroATAConfigurations : IEntityTypeConfiguration<RegistroATA>
    {
        public void Configure(EntityTypeBuilder<RegistroATA> builder)
        {
            builder
                 .HasKey(r => r.Id); // DEFININDO CHAVE PRIMÁRIA

            builder
                .HasMany(registroATA => registroATA.Locacoes) // UM RegistroATA PODE ESTAR EM MAIS DE UMA Locações => ATRIBUTO ESTÁ EM "RegistroATA"
                .WithOne() // UM Locacao VAI TER UM RegistroATA POR VEZ NA LINHA
                .HasForeignKey(locacao => locacao.IdRegistroATA) // É O FK DE REGISTRO EM "Locacao"
                .OnDelete(DeleteBehavior.Restrict); // SEMPRE PREFERE O RESTRICT
        }
    }
}
