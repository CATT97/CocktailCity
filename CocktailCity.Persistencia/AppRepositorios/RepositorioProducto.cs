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
        Producto IRepositorioProducto.UpdateProducto(Producto producto){
            var ProductoEncontrado = _appContext.Productos.Find(producto.ID);
            if(ProductoEncontrado != null){
                ProductoEncontrado.Nombre = producto.Nombre;
                ProductoEncontrado.Size = producto.Size;
                ProductoEncontrado.Precio = producto.Precio;
                ProductoEncontrado.Descripcion = producto.Descripcion;
                ProductoEncontrado.Cantidad = producto.Cantidad;
                _appContext.SaveChanges();
            }
            return ProductoEncontrado;
        }
        public void DeleteProducto(int idProducto){
            var productoEncontrado = _appContext.Productos.Find(idProducto);
            if (productoEncontrado == null) 
            return;
            _appContext.Productos.Remove(productoEncontrado);
            _appContext.SaveChanges();
        }
    }
}