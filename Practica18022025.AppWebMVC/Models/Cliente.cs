using System.ComponentModel.DataAnnotations;

namespace Practica18022025.AppWebMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Nombre Completo")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 10 caracteres.")]
        public string Nombre { get; set; }
        public string Apellido { get;set; }
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}
