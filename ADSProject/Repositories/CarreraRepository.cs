using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarrera = new List<Carrera>
        {
            new Carrera
            {
                IdCarrera = 1,
                Codigo = "I01001",
                Nombre = "Ingenieria en Sistemas Computacionales"
            },
            new Carrera
            {
                IdCarrera = 2,
                Codigo = "I02001",
                Nombre = "Ingenieria Electrica"
            }
            ,
            new Carrera
            {
                IdCarrera = 3,
                Codigo = "I03001",
                Nombre = "Ingenieria en Agronegocios"
            },
            new Carrera
            {
                IdCarrera = 4,
                Codigo = "I04001",
                Nombre = "Ingenieria Industrial"
            }
        };
        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                int indice = lstCarrera.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarrera[indice] = carrera;
                return idCarrera;

            }
            catch (Exception e)
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
            catch (Exception e)
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
            catch (Exception e)
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
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
