using EctoTect.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiEctoTec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        public DireccionController(IDireccionesService direccionService)
        {
            _direccionService = direccionService;
        }

        private readonly IDireccionesService _direccionService;

        [HttpGet("ObtenerTodasLasDirecciones")]
        public async Task<IActionResult> ConsultarTodasLasDirecciones()
        {
            try
            {
                var direccionesResponse = await _direccionService.ObtenerTodasLasDirecciones();
                return Ok(direccionesResponse);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("ObtenerDireccionesFiltradas")]
        public async Task<IActionResult> FiltrarDirecciones([FromBody] string nombre)
        {
            try
            {
                var direccionesResponse = await _direccionService.ObtenerDireccionesFiltradas(nombre);
                return Ok(direccionesResponse);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
