using System;
using System.Collections.Generic;
using CocktailCity.Dominio;
using CocktailCity.Persistencia;

namespace CocktailCity.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario();
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando");
            AddUsuario();
            //GetAllUsuarios();
        }
        private static void AddUsuario(){
            var usuario = new Usuario{
                Nombre = "Juan Davis",
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
    }
}
