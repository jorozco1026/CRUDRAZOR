using Microsoft.EntityFrameworkCore;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Persistencia
{
    public class AppContext : DbContext
    {
         public DbSet<Formador> Formadores { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=localhost; Database=Desault; user id=sa; password=12345; Initial Catalog = ProyectoG58");
               //.UseSqlServer("Data Source=DESKTOP-JFCF57P; Initial Catalog=ProyectoG58");
            }
        }   
    }
}
