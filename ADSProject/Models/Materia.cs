﻿using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdMateria))]
    public class Materia
    {
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombreMateria { get; set; }
    }
}
