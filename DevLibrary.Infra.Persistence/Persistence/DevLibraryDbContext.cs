using DevLibrary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DevLibrary.Infra.Persistence.Persistence
{
    public class DevLibraryDbContext : DbContext
    {
        public DevLibraryDbContext(DbContextOptions<DevLibraryDbContext> options)
            : base(options)
        {

        }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<RegistroATA> RegistroATA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
