using Microsoft.EntityFrameworkCore;

namespace GestorGastos
{
    public class ApplicationDbContext : DbContext
    {
        //recibe las opciones desde el Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; } 

    }
}