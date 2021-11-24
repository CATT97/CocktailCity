using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CocktailCity.Dominio;
using CocktailCity.Persistencia;

namespace MiprimeraApp.frontend.Pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        public Producto producto {get;set;}
        public CreateModel(IRepositorioProducto repoProducto){
            _repoProducto = repoProducto;
        }
        public void OnGet()
        {
            producto = new Producto();
        }
        public IActionResult OnPost(Producto producto){
            if(ModelState.IsValid){
                _repoProducto.AddProducto(producto);
                return RedirectToPage("List");
            }
            else{
                return Page();
            }
        }
    }
}
