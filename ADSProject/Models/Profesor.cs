using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdProfesor))]
    public class Profesor
    {
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombresProfesor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string ApellidosProfesor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [MinLength(length: 254, ErrorMessage = "La longitud del campo no puede ser menor a 254 caracteres.")]
        public string Email { get; set; }
    }
}
