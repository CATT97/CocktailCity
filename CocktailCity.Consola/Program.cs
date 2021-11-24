using System;
using System.Collections.Generic;
using CocktailCity.Dominio;
using CocktailCity.Persistencia;

namespace CocktailCity.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario();
        private static IRepositorioProducto _repoProducto = new RepositorioProducto();
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando");
            //USUARIO
            //AddUsuario();
            //GetAllUsuarios();
            //PRODUCTO
            //AddProducto();
            //cdGetAllProductos();
        }
        private static void AddUsuario(){
            var usuario = new Usuario{
                Nombre = "Juan David",
                Nickname = "Juanda",
                TipoDocumento = TipoDocumento.CC,
                NumeroDocumento = "56789",
                Genero = Genero.Masculino,
                Password = "Aaaaaa",
                NumeroContacto = "1234568",
                CorreoElectronico = "juan@gmail.com",
                Direccion = "Cll 2 # 3 - 4",
                Barrio = "no se",
                Ciudad = "Manizales",
                Perfil = Perfil.Empleado
            };
            _repoUsuario.AddUsuario(usuario);
        }
        private static void GetAllUsuarios(){
            IEnumerable<Usuario> usuarios = _repoUsuario.GetAllUsuarios();
            foreach(var usuario in usuarios){
                Console.WriteLine(usuario.Nombre+" "+usuario.Nickname+" "+usuario.TipoDocumento);
            }
        }
        private static void AddProducto(){
            var producto = new Producto{
                Nombre = "GreenApple",
                Size = 12,
                Cantidad = "38",
                Precio = 10000,
                Descripcion = "Manzana verde con limoncito",
            };
            _repoProducto.AddProducto(producto);
        }

        private static void GetAllProductos(){
            IEnumerable<Producto> productos = _repoProducto.GetAllProductos();
            foreach(var producto in productos){
                Console.WriteLine(producto.Nombre+" "+producto.Size+" "+producto.Cantidad+" "+producto.Precio+" "+producto.Descripcion);
            }
        }
    }
}
