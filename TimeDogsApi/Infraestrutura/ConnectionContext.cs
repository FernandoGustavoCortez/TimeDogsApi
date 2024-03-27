using Microsoft.EntityFrameworkCore;
using TimeDogsApi.Model;

namespace TimeDogsApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Cachorro> Cachorros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=timedogs;" +
                "User Id=postgres;" +
                "Password=1234;");
    }
}
