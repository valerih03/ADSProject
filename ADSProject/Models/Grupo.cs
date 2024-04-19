using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdGrupo))]
    public class Grupo
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdGrupo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Anio { get; set; }
    }
}
