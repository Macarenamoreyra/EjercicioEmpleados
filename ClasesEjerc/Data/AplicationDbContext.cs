using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClasesEjerc.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=PruebaEF;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
