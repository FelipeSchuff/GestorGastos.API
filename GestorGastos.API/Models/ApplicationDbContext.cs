using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestorGastos
{
    internal class ApplicationDbContext : DbContext
    {
        // Tabla para guardar los datos "Gastos"
        public DbSet<Gasto> Gastos { get; set; }

        // Direccion donde se crea la base de datos 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Mini server LocalDB 
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GestorGastosDB;Trusted_Connection=True;");

        }
    }
}
