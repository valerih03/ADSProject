using ADSProject.Interfaces;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADSProject.Repositories
{
    public class GrupoRepository : IGrupo
    {
        private List<Grupo> listaGrupos = new List<Grupo>
        {
            new Grupo { IdGrupo = 1, IdCarrera = 1, IdMateria = 1, IdProfesor = 1, Ciclo = 1, Anio = 2024 }
        };

        public int ActualizarGrupo(int idGrupo, Grupo grupo)
        {
            try
            {
                int bandera = 0;

                int index = listaGrupos.FindIndex(tmp => tmp.IdGrupo == idGrupo);

                if (index >= 0)
                {
                    listaGrupos[index] = grupo;
                    bandera = idGrupo;
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

        public int AgregarGrupo(Grupo grupo)
        {
            try
            {
                if (listaGrupos.Count > 0)
                {
                    grupo.IdGrupo = listaGrupos.Last().IdGrupo + 1;
                }
                listaGrupos.Add(grupo);

                return grupo.IdGrupo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                bool bandera = false;
                int index = listaGrupos.FindIndex(aux => aux.IdGrupo == idGrupo);

                if (index >= 0)
                {
                    listaGrupos.RemoveAt(index);
                    bandera = true;
                }

                return bandera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Grupo ObtenerGrupoPorID(int idGrupo)
        {
            try
            {
                var grupo = listaGrupos.FirstOrDefault(tmp => tmp.IdGrupo == idGrupo);

                return grupo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Grupo> ObtenerGrupos()
        {
            try
            {
                return listaGrupos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
