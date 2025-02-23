using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebAPI8.Models;

namespace WebAPI8.Data
{
    public class AppDbContext : DbContext
    {
      
            public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
            {

            }

        
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

    }
}
