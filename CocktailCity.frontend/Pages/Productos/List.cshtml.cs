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
    public class ListModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        public IEnumerable<Producto> productos {get;set;}
        public ListModel(IRepositorioProducto repoProducto){
            _repoProducto = repoProducto;
        }
        public void OnGet()
        {
            productos = _repoProducto.GetAllProductos();
        }
    }
}
