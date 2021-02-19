using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevLibrary.Infra.Persistence
{
    public class DevLibraryDbContext : DbContext
    {
        public DevLibraryDbContext(DbContextOptions<DevLibraryDbContext> options)
            :base(options)
        {

        }

        public DbSet<Alunos> Aluno { get; set; }
    }
}
