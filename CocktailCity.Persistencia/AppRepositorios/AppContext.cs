using Microsoft.EntityFrameworkCore;
using CocktailCity.Dominio;

namespace CocktailCity.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<Venta> Ventas {get;set;}
        public DbSet<Cantidad> Cantidades {get;set;}
        public DbSet<Producto> Productos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Initial Catalog=CocktailCity; Data Source= DESKTOP-8JS3SSV\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}