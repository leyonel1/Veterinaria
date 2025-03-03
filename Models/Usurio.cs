using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace VeterinariaAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; } // "Cliente" o "Doctor"
    }
}