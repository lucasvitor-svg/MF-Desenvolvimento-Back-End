using Microsoft.EntityFrameworkCore;

namespace MF_Desenvolvimento_Back_End.Data
{
    public class MFContext : DbContext
    {
        public MFContext(DbContextOptions<MFContext> options) : base(options)
        {
        }

        // Adicione aqui DbSet<T> para suas entidades, por exemplo:
        // public DbSet<Usuario> Usuarios { get; set; }
    }
}
