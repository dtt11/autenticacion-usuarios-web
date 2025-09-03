using Microsoft.AspNetCore.Identity;

namespace AutenticacionWeb.Models
{
    public class Usuario : IdentityUser 
    {
        public string Nombre { get; set; } = "";

        public string Apellido { get; set; } = "";
        public string Direccion { get; set; } = "";

        public DateTime FechaCreacion { get; set; } 
    }
}
