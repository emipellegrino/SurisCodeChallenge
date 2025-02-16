using Microsoft.AspNetCore.Mvc;
using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Servicios.Interfaces;

namespace SurisCodeChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        private readonly IServicioService _servicioService;

        public ReservasController(IReservaService reservaService, IServicioService servicioService)
        {
            _reservaService = reservaService;
            _servicioService = servicioService;
        }

        [HttpGet("GetServicios")]
        public async Task<IActionResult> GetServicios()
        {
            var servicios = await _servicioService.GetAllServicios();
            return Ok(servicios);
        }

        [HttpGet("GetReservas")]
        public async Task<IActionResult> GetReservas()
        {
            var reservas = await _reservaService.GetAllReservas();
            return Ok(reservas);
        }

        [HttpPost("InsertReserva")]
        public async Task<IActionResult> PostReserva([FromBody] Reserva reserva)
        {
            try
            {
                await _reservaService.CreateReserva(reserva);
                return Ok(new { success = true, reserva });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error al crear la reserva.");
            }
        }
    }
}
