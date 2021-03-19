using EctoTect.Core.CustomEntites;
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
    }
}
