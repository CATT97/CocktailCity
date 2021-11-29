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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioUsuario _repoUsuario;
        public Usuario usuario {get;set;}
        public DeleteModel(IRepositorioUsuario repoUsuario){
            _repoUsuario = repoUsuario;
        }
        public IActionResult OnGet(int id)
        {
            usuario = _repoUsuario.GetUsuario(id);
            if(usuario == null){
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(Usuario usuario){
            _repoUsuario.DeleteUsuario(usuario.ID);
            return RedirectToPage("List");
        }
    }
}
