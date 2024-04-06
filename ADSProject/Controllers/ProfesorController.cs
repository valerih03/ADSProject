using ADSProject.Interfaces;
using ADSProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADSProject.Controllers
{
    [Route("api/profesores/")]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesor profesor;

        public ProfesorController(IProfesor profesor)
        {
            this.profesor = profesor;
        }

        [HttpDelete("eliminarProfesor/{idProfesor}")]
        public ActionResult<string> EliminarProfesor(int idProfesor)
        {
            try
            {
                bool eliminado = this.profesor.EliminarProfesor(idProfesor);

                if (eliminado)
                {
                    return Ok(new { pCodRespuesta = "0000000" });
                }
                else
                {
                    return NotFound(new { pCodRespuesta = "999999" });
                }
            }
            catch (Exception)
            {
                // Manejar la excepción según sea necesario
                throw;
            }
        }
    }
}
