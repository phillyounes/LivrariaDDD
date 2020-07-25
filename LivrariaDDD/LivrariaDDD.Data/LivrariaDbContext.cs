using LivrariaDDD.Domain;
using Microsoft.EntityFrameworkCore;

namespace LivrariaDDD.Infra.Data
{
    public class LivrariaDbContext : DbContext
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            $"Initial Catalog=LivrariaDDD;" +
            $"Integrated Security=True;" +
            $"Connect Timeout=30;" +
            $"Encrypt=False;" +
            $"TrustServerCertificate=False;" +
            $"ApplicationIntent=ReadWrite;" +
            $"MultiSubnetFailover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
