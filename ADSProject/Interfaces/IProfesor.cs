using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Interfaces
{
    public interface IProfesor
    {
        int AgregarProfesor(Profesor profesor);
        int ActualizarProfesor(int idProfesor, Profesor profesor);
        List<Profesor> ObtenerProfesores();
        Profesor ObtenerProfesorPorID(int idProfesor);
        bool EliminarProfesor(int idProfesor);
    }
}
