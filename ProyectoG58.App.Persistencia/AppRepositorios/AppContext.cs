using Microsoft.EntityFrameworkCore;
using ProyectoG58.App.Dominio.Entidades;

namespace ProyectoG58.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
         public DbSet<Formador> Formadores { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ProyectoG58");
            }
        }    
    }
}
