using System.Collections.Generic;
using System.Linq;
using CocktailCity.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CocktailCity.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext = new AppContext();
        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario){
            var usuarioAdicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }
        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios(){
            return _appContext.Usuarios;
        }
        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.Find(idUsuario);
        }
    }
}