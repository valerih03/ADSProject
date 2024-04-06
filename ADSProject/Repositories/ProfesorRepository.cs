using ADSProject.Interfaces;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADSProject.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        private List<Profesor> listaProfesores = new List<Profesor>
        {
            new Profesor { IdProfesor = 1, NombresProfesor = "Juan", ApellidosProfesor = "Perez", Email = "juan@example.com" }
        };

        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                int bandera = 0;

                int index = listaProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                if (index >= 0)
                {
                    listaProfesores[index] = profesor;
                    bandera = idProfesor;
                }
                else
                {
                    bandera = -1;
                }

                return bandera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                if (listaProfesores.Count > 0)
                {
                    profesor.IdProfesor = listaProfesores.Last().IdProfesor + 1;
                }
                listaProfesores.Add(profesor);

                return profesor.IdProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                bool bandera = false;
                int index = listaProfesores.FindIndex(aux => aux.IdProfesor == idProfesor);

                if (index >= 0)
                {
                    listaProfesores.RemoveAt(index);
                    bandera = true;
                }

                return bandera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profesor ObtenerProfesorPorID(int idProfesor)
        {
            try
            {
                var profesor = listaProfesores.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);

                return profesor;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> ObtenerProfesores()
        {
            try
            {
                return listaProfesores;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
