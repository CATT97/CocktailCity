using System.Collections.Generic;
using CocktailCity.Dominio;
namespace CocktailCity.Persistencia
{
    public interface IRepositorioProducto
    {
         IEnumerable<Producto> GetAllProductos();
         Producto AddProducto(Producto producto);
         //Producto UpdateProducto(Producto producto);
         //void DeleteProducto(int idProducto);
         Producto GetProducto(int idProducto);
    }
}