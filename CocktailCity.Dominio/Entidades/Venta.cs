using System;

namespace CocktailCity.Dominio
{
    public class Venta
    {
        public int IDVenta {get;set;}
        public DateTime FechaHora {get;set;}
        public float ValorTotal {get;set;}
        public int IDUsuario {get;set;}
        public string Estado {get;set;}
    }
}