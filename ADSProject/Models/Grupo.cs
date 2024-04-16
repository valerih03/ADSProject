﻿using System.ComponentModel.DataAnnotations;
namespace ADSProject.Models
{
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
