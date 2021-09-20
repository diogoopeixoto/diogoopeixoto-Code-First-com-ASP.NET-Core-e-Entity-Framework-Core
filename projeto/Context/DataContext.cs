using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto.Meppings;
using projeto.Models;

namespace projeto.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
