using EctoTect.Core.CustomEntites;
using EctoTect.Core.Entities;
using System.Threading.Tasks;

namespace EctoTect.Core.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Registra un usuario nuevo en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task<BasicResponse> RegistrarUsuario(Usuario usuario);
    }
}
