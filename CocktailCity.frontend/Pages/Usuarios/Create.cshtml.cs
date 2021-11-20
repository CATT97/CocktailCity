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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioUsuario _repoUsuario;
        public Usuario usuario {get;set;}
        public CreateModel(IRepositorioUsuario repoUsuario){
            _repoUsuario = repoUsuario;
        }
        public void OnGet()
        {
            usuario = new Usuario();
        }
        public IActionResult OnPost(Usuario usuario){
            if(ModelState.IsValid){
                _repoUsuario.AddUsuario(usuario);
                return RedirectToPage("List");
            }
            else{
                return Page();
            }
        }
    }
}
