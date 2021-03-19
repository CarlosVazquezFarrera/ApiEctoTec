using AutoMapper;
using EctoTect.Core.CustomEntites;
using EctoTect.Core.DTOs;
using EctoTect.Core.Entities;
using EctoTect.Core.Interfaces.Repository;
using EctoTect.Core.Interfaces.Service;
using System.Threading.Tasks;

namespace EctoTect.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        #region Constructor
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this._usuarioRepository = usuarioRepository;
            this._mapper = mapper;
        }
        #endregion

        #region Propiedades
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Métodos
        public async Task<BasicResponse> RegistrarUsuario(UsuarioDTO usuario)
        {
            return await _usuarioRepository.RegistrarUsuario(_mapper.Map<Usuario>(usuario));
        }
        #endregion
    }
}
