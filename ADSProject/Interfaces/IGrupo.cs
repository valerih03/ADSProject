using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Interfaces
{
    public interface IGrupo
    {
        int AgregarGrupo(Grupo grupo);
        int ActualizarGrupo(int idGrupo, Grupo grupo);
        List<Grupo> ObtenerGrupos();
        Grupo ObtenerGrupoPorID(int idGrupo);
        bool EliminarGrupo(int idGrupo);
    }
}
