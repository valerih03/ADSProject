using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarrera = new List<Carrera>
        {
            new Carrera { IdCarrera = 1,CodigoCarrera = "I01001",
                NombreCarrera = "Ingenieria en Sistemas Computacionales" },
            new Carrera { IdCarrera = 2,CodigoCarrera = "I02001",
                NombreCarrera = "Ingenieria Electrica"},
            new Carrera { IdCarrera = 3, CodigoCarrera = "I03001",
                NombreCarrera = "Ingenieria en Agronegocios" },
            new Carrera { IdCarrera = 4,CodigoCarrera = "I04001",
                NombreCarrera = "Ingenieria Industrial" }
        };
        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                int indice = lstCarrera.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarrera[indice] = carrera;
                return idCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarrera.Count > 0)
                {
                    carrera.IdCarrera = lstCarrera.Last().IdCarrera + 1;
                }
                lstCarrera.Add(carrera);
                return carrera.IdCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                int indice = lstCarrera.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarrera.RemoveAt(indice);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Carrera ObtenerTodasLasCarrerasPorID(int idCarrera)
        {
            try
            {
                Carrera carrera = lstCarrera.FirstOrDefault(tmp => tmp.IdCarrera == idCarrera);
                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Carrera> ObtenerCarreras()
        {
            try
            {
                return lstCarrera;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
