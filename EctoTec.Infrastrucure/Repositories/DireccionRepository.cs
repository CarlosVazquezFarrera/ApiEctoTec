namespace EctoTec.Infrastrucure.Repositories
{
    using EctoTec.Infrastrucure.Data;
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.Interfaces.Repository;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Threading.Tasks;

    public class DireccionRepository : IDireccionRepository
    {
        #region Constructor
        public DireccionRepository(EctoTecContext contexto)
        {
            this.baseDeDatos = contexto;
        }
        #endregion

        #region Propiedades
        private readonly EctoTecContext baseDeDatos;
        #endregion

        #region Métodos
        public async Task<Response<List<DireccionCustomEntities>>> ObtenerTodasLasDirecciones()
        {
            Response<List<DireccionCustomEntities>> responseDirecciones = new Response<List<DireccionCustomEntities>>();
            try
            {
                await baseDeDatos.Database.OpenConnectionAsync();
                var dbCommand = baseDeDatos.Database.GetDbConnection().CreateCommand();

                dbCommand.CommandText = "[dbo].[ConsultarDirecciones]";
                dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DbDataReader resultadoDb = await dbCommand.ExecuteReaderAsync();
                responseDirecciones.Data = new List<DireccionCustomEntities>();

                if (resultadoDb.HasRows)
                {
                    if (resultadoDb.HasRows)
                    {
                        while (resultadoDb.Read())
                        {
                            responseDirecciones.Data.Add(new DireccionCustomEntities
                            {
                                Pais = resultadoDb.GetString(0),
                                IdPais = resultadoDb.GetInt32(1),
                                Entidad = resultadoDb.GetString(2),
                                IdEntidad = resultadoDb.GetInt32(3),
                                Ciudad = resultadoDb.GetString(4),
                                IdCiudad = resultadoDb.GetInt32(5)
                            });
                        }
                        responseDirecciones.Exito = true;
                    }
                }
            }
            catch (Exception es)
            {

                responseDirecciones.Mensaje = "Hubo un problema en base de datos";
                responseDirecciones.Data = new List<DireccionCustomEntities>();
            }
            return responseDirecciones;
        } 
        #endregion
    }
}
