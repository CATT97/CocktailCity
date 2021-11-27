using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CocktailCity.Dominio;
using CocktailCity.Persistencia;

namespace CocktailCity.frontend.Pages.Productos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        public Producto producto {get;set;}    
        public DetailsModel(IRepositorioProducto repoProducto){
            _repoProducto =  repoProducto;
        }
        public IActionResult OnGet(int id)
        {
            producto = _repoProducto.GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
    }
}
