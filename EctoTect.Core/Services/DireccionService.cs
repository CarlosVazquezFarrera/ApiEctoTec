namespace EctoTect.Core.Services
{
    using EctoTect.Core.CustomEntites;
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
        public Task ObtenerDireccionesFiltradas()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<DireccionCustomEntities>>> ObtenerTodasLasDirecciones()
        {
            return await _direccionRepoaitory.ObtenerTodasLasDirecciones();
        } 
        #endregion
    }
}
