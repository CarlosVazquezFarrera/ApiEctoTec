using EctoTect.Core.DTOs;
using EctoTect.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiEctoTec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        #region Constrcutor
        public MailController(IMailService mailService)
        {
            this._mailService = mailService;
        }
        #endregion

        #region Propiedades
        private readonly IMailService _mailService;

        #endregion

        #region Métodos
        [HttpPost("EnviarCorreo")]
        public async Task<IActionResult> EnviarCorreo([FromBody] UsuarioDTO usuario)
        {
            try
            {
                var direccionesResponse = await _mailService.EnviarMail(usuario);
                return Ok(direccionesResponse);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        } 
        #endregion
    }
}
