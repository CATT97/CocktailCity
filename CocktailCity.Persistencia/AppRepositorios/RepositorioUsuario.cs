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
        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario){
            var UsuarioEncontrado = _appContext.Usuarios.Find(usuario.ID);
            if(UsuarioEncontrado != null){
                UsuarioEncontrado.Nombre = usuario.Nombre;
                UsuarioEncontrado.Nickname = usuario.Nickname;
                UsuarioEncontrado.TipoDocumento = usuario.TipoDocumento;
                UsuarioEncontrado.NumeroDocumento = usuario.NumeroDocumento;
                UsuarioEncontrado.Genero = usuario.Genero;
                UsuarioEncontrado.Password = usuario.Password;
                UsuarioEncontrado.NumeroContacto = usuario.NumeroContacto;
                UsuarioEncontrado.CorreoElectronico = usuario.CorreoElectronico;
                UsuarioEncontrado.Direccion = usuario.Direccion;
                UsuarioEncontrado.Barrio = usuario.Barrio;
                UsuarioEncontrado.Ciudad = usuario.Ciudad;
                UsuarioEncontrado.Perfil = usuario.Perfil;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }
        public void DeleteUsuario(int idUsuario){
            var usuarioEncontrado = _appContext.Usuarios.Find(idUsuario);
            if (usuarioEncontrado == null) 
            return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }
    }
}