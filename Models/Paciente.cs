using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace VeterinariaAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public int PropietarioId { get; set; }
        public Usuario Propietario { get; set; }
    }
}