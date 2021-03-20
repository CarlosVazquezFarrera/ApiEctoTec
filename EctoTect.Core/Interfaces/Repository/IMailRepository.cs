
namespace EctoTect.Core.Interfaces.Repository
{
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.Entities;
    using System.Threading.Tasks;
    public interface IMailRepository
    {
        /// <summary>
        /// Envía el mail al usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<BasicResponse> EnviarMail(Usuario usuario);
    }
}
