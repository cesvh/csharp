using _001WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _001WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventoController(IEventoService service) {
            _eventoService = service;
        }

        [HttpGet]
        public IActionResult Get() {
            var eventos = _eventoService.GetEventos();
            return Ok(eventos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var evento = _eventoService.GetEvento(id);
            if (evento == null) {
                return NotFound();
            }
            return Ok(evento);
        }
    }
}
