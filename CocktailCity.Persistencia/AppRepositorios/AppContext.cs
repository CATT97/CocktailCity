using Microsoft.EntityFrameworkCore;
using CocktailCity.Dominio;

namespace CocktailCity.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Usuario> Usuario {get;set;}
        public DbSet<Venta> Venta {get;set;}
        public DbSet<Cantidad> Cantidad {get;set;}
        public DbSet<Producto> Producto {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital2207208; Data Source= DESKTOP-8JS3SSV\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}