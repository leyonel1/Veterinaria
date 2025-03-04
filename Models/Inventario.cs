using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace VeterinariaAPI.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string FechaVencimiento { get; set; }
        public string FechaLote { get; set; }
    }
}