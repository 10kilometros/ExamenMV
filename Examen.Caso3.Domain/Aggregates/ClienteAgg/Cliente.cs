using System;
using Examen.Caso3.Domain.EntityBase;

namespace Examen.Caso3.Domain.Aggregates.ClienteAgg
{
    public class Cliente : Entity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        public void Agregar()
        {
            Activo = true;
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
