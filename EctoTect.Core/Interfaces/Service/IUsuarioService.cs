namespace EctoTect.Core.Interfaces.Service
{
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.DTOs;
    using System.Threading.Tasks;
    public interface IUsuarioService
    {
        /// <summary>
        /// Ejecuta el método del Api que realiza el registro del usuario y envía el correo si el registro es exitoso
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="ciudad"></param>
        /// <returns></returns>
        Task<BasicResponse> RegistrarUsuario(UsuarioDTO usuario);
    }
}
