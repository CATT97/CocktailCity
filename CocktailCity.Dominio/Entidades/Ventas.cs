namespace CocktailCity.Dominio.Entidades
{
    public class Ventas
    {
        public int IDVentas {get;set;}
        public DateTime FechaHora {get;set;}
        public int IDCantidad {get;set;}
        public float ValorTotal {get;set;}
        public int IDUsuario {get;set;}
        public string Estado {get;set;}
    }
}