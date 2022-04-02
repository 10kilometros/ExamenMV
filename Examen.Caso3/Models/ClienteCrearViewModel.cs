using System;
using System.ComponentModel.DataAnnotations;

namespace Examen.Caso3.Models
{
    public class ClienteCrearViewModel
    {
        [Required(ErrorMessage = "Requerido."), MaxLength(250, ErrorMessage = "Máximo 250 caracteres.")]
        [Display(Name = "Nombres:")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Requerido."), MaxLength(250, ErrorMessage = "Máximo 250 caracteres.")]
        [Display(Name = "Apellidos:")]
        public string ApellidosCompletos { get; set; }

        [Required(ErrorMessage = "Requerido."), MaxLength(320, ErrorMessage = "Máximo 320 caracteres.")]
        [EmailAddress]
        [Display(Name = "Correo:")]
        public string Correo { get; set; }

        [Display(Name = "Fecha de nacimiento:")]
        public DateTime? FechaNacimiento { get; set; }

        [MaxLength(800)]
        [Display(Name = "Dirección:")]
        public string Direccion { get; set; }
    }
}
