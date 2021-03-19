using EctoTect.Core.CustomEntites;
using EctoTect.Core.DTOs;
using EctoTect.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiEctoTec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region Constructor
        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
        #endregion

        #region Propiedades
        private readonly IUsuarioService _usuarioService;
        #endregion

        [HttpPost("RegistrarUsuario")]
        public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDTO usuario)
        {
            try
            {
                var direccionesResponse = await _usuarioService.RegistrarUsuario(usuario);
                return Ok(direccionesResponse);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
