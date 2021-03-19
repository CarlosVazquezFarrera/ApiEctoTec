using EctoTect.Core.CustomEntites;
using EctoTect.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EctoTect.Core.Interfaces.Service
{
    public interface IDireccionesService
    {
        /// <summary>
        /// Obtiene el listado completo de la base de datos
        /// </summary>
        /// <returns></returns>
        Task<Response<List<DireccionCustomEntities>>> ObtenerTodasLasDirecciones();

        /// <summary>
        /// Obtiene un listado filtrado de base de datos con base al parámetro en viado
        /// </summary>
        /// <returns></returns>
        Task<Response<List<DireccionCustomEntities>>> ObtenerDireccionesFiltradas(string ciudad);
    }
}
