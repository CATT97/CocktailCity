using System.Collections.Generic;
using System.Linq;
using CocktailCity.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CocktailCity.Persistencia
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly AppContext _appContext = new AppContext();
        Producto IRepositorioProducto.AddProducto(Producto producto){
            var productoAdicionado = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoAdicionado.Entity;
        }
        IEnumerable<Producto> IRepositorioProducto.GetAllProductos(){
            return _appContext.Productos;
        }
        Producto IRepositorioProducto.GetProducto(int idProducto)
        {
            return _appContext.Productos.Find(idProducto);
        }
    }
}