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
            //AddUsuario();
            GetAllUsuarios();
        }
        private static void AddUsuario(){
            var usuario = new Usuario{
                Nombre = "David Marin",
                Nickname = "Marin123",
                TipoDocumento = TipoDocumento.CC,
                NumeroDocumento = "123456",
                Genero = Genero.Masculino,
                Password = "David987",
                NumeroContacto = "3231231212",
                CorreoElectronico = "david@gmail.com",
                Direccion = "Cll 2 # 3 - 4",
                Barrio = "no se",
                Ciudad = "Manizales",
                Perfil = Perfil.Administrador
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
