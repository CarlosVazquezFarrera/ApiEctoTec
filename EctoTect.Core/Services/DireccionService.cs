namespace EctoTect.Core.Services
{
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.DTOs;
    using EctoTect.Core.Interfaces.Repository;
    using EctoTect.Core.Interfaces.Service;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class DireccionService : IDireccionesService
    {

        #region Constructor
        public DireccionService(IDireccionRepository direccionRepository)
        {
            this._direccionRepoaitory = direccionRepository;
        }
        #endregion

        #region Propiedades
        private readonly IDireccionRepository _direccionRepoaitory;
        #endregion

        #region Métodos
        public async Task<Response<List<DireccionCustomEntities>>> ObtenerDireccionesFiltradas(string ciudad)
        {
            if (string.IsNullOrEmpty(ciudad))
                return new Response<List<DireccionCustomEntities>> { Exito = false, Mensaje = "Debe enviar un parámetro"};
            return await _direccionRepoaitory.ObtenerDireccionesFiltradas(ciudad);
        }

        public async Task<Response<List<DireccionCustomEntities>>> ObtenerTodasLasDirecciones()
        {
            return await _direccionRepoaitory.ObtenerTodasLasDirecciones();
        } 
        #endregion
    }
}
