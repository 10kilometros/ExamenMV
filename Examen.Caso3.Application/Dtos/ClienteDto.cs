using System;

namespace Examen.Caso3.Application.Dtos
{
    public class ClienteDto : EntityDto
    {
        public string Nombres { get; set; }
        public string ApellidosCompletos { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
    }
}
