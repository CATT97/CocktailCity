namespace CocktailCity.Dominio
{
    public class Usuario
    {
        public int IDUsuario {get;set;}
        public string Nombre {get;set;}
        public string Nickname {get;set;}
        public TipoDocumento TipoDocumento {get;set;}
        public string NumeroDocumento {get;set;}
        public Genero Genero {get;set;}
        public string Password {get;set;}
        public string NumeroContacto {get;set;}
        public string CorreoElectronico {get;set;}
        public string Direccion {get;set;}
        public string Barrio {get;set;}
        public string Ciudad {get;set;}
        public Perfil Perfil {get;set;}
    }
}