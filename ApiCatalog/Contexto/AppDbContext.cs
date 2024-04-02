using Microsoft.EntityFrameworkCore;
using ApiCatalog.Models;

namespace ApiCatalog.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options)
        {
            
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
