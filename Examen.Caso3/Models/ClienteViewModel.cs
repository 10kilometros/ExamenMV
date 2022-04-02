using System;

namespace Examen.Caso3.Models
{
    public class ClienteViewModel
    {
        public int Id{ get; set; }
        public string NombresApellidos { get; set; }

        public string Correo { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
