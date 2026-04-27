using Microsoft.EntityFrameworkCore;

namespace MF_Desenvolvimento_Back_End.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
