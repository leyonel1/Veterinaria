using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace VeterinariaAPI.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int DoctorId { get; set; }
        public Usuario Doctor { get; set; }
    }
}