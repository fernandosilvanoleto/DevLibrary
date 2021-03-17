using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevLibrary.Infrastructure.Persistence.Configurations
{
    public class AlunosConfigurations : IEntityTypeConfiguration<Alunos>
    {
        public void Configure(EntityTypeBuilder<Alunos> builder)
        {
            builder
                .HasKey(a => a.Id); // DEFININDO CHAVE PRIMÁRIA

            //builder
            //     .HasMany(a => a.Matricula) // UM ALUNO PODE TER MAIS DE UMA MATRÍCULA => ATRIBUTO ESTÁ EM "Alunos"
            //    .WithOne() // UM RegistroATA VAI TER UM ALUNO RELACIONADO POR VEZ NA LINHA
            //    .HasForeignKey(r => r.IdAluno) // É O FK EM "RegistroATA"
            //    .OnDelete(DeleteBehavior.Restrict); // SEMPRE PREFERE O RESTRICT
        }
    }
}
