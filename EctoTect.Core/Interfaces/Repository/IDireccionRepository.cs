using EctoTect.Core.CustomEntites;
using EctoTect.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EctoTect.Core.Interfaces.Repository
{
    public interface IDireccionRepository
    {
        /// <summary>
        /// Ejecuta el procedimiento almacenado de la base de datos que retorna toda la información
        /// </summary>
        /// <returns></returns>
        Task<Response<List<DireccionCustomEntities>>> ObtenerTodasLasDirecciones();
        /// <summary>
        /// Ejecuta el procedimiento almacenado de la base de datos que retorna la informacióno fisltrada
        /// </summary>
        /// <param name="ciudad"></param>
        /// <returns></returns>
        Task<Response<List<DireccionCustomEntities>>> ObtenerDireccionesFiltradas(string ciudad);
    }
}
