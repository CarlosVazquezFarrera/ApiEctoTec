namespace EctoTect.Core.Interfaces.Service
{
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.DTOs;
    using System.Threading.Tasks;
    public interface IMailService
    {
        /// <summary>
        /// Ejecuta el método que envía el correo al usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<BasicResponse> EnviarMail(UsuarioDTO usuario);
    }
}
