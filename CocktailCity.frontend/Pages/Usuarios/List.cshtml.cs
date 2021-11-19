using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CocktailCity.Dominio;
using CocktailCity.Persistencia;

namespace CocktailCity.frontend.Pages.Usuarios
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioUsuario _repoUsuario;
        public IEnumerable<Usuario> usuarios {get;set;}
        public ListModel(IRepositorioUsuario repoUsuario){
            _repoUsuario = repoUsuario;
        }
        public void OnGet()
        {
            usuarios = _repoUsuario.GetAllUsuarios();
        }
    }
}