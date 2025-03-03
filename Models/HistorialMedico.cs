using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace VeterinariaAPI.Models
{
    public class HistorialMedico
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int DoctorId { get; set; }
        public Usuario Doctor { get; set; }
    }
}
