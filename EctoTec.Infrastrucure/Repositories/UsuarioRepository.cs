namespace EctoTec.Infrastrucure.Repositories
{
    using EctoTec.Infrastrucure.Data;
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.Entities;
    using EctoTect.Core.Interfaces.Repository;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Data.Common;
    using System.Threading.Tasks;
    public class UsuarioRepository : IUsuarioRepository
    {

        public UsuarioRepository(EctoTecContext contexto)
        {
            this.baseDeDatos = contexto;
        }
        #region Propiedades
        private readonly EctoTecContext baseDeDatos;
        #endregion
        public async Task<BasicResponse> RegistrarUsuario(Usuario usuario)
        {
            BasicResponse responseRegistro = new BasicResponse();
            try
            {
                await baseDeDatos.Database.OpenConnectionAsync();
                var dbCommand = baseDeDatos.Database.GetDbConnection().CreateCommand();
                #region Parametros

                DbParameter nombre = dbCommand.CreateParameter();
                nombre.ParameterName = "Nombre";
                nombre.Value = usuario.Nombre;
                dbCommand.Parameters.Add(nombre);

                DbParameter mail = dbCommand.CreateParameter();
                mail.ParameterName = "Mail";
                mail.Value = usuario.Mail;
                dbCommand.Parameters.Add(mail);

                DbParameter telefono = dbCommand.CreateParameter();
                telefono.ParameterName = "Telefono ";
                telefono.Value = usuario.Telefono;
                dbCommand.Parameters.Add(telefono);


                DbParameter fechaNacimiento = dbCommand.CreateParameter();
                fechaNacimiento.ParameterName = "FechaNacimiento ";
                fechaNacimiento.Value = usuario.Fecha;
                dbCommand.Parameters.Add(fechaNacimiento);


                DbParameter ciudadNacimiento = dbCommand.CreateParameter();
                ciudadNacimiento.ParameterName = "CiudadNacimiento ";
                ciudadNacimiento.Value = usuario.IdCiudad;
                dbCommand.Parameters.Add(ciudadNacimiento);
                #endregion

                dbCommand.CommandText = "[dbo].[IngresarUsuario]";
                dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DbDataReader resultadoDb = await dbCommand.ExecuteReaderAsync();

                if (resultadoDb.HasRows)
                {
                    if (resultadoDb.Read())
                    {
                        responseRegistro.Exito = resultadoDb.GetBoolean(0);
                        responseRegistro.Mensaje = resultadoDb.GetString(1);
                    }
                }
            }
            catch (Exception)
            {

                responseRegistro.Mensaje = "Hubo un problema en base de datos";
            }
            finally
            {
                await baseDeDatos.Database.CloseConnectionAsync();
            }
            return responseRegistro;
        }
    }
}
