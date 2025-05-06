using _001WebApi.Models;

namespace _001WebApi.Services
{
    public interface IEventoService
    {
        public IEnumerable<Eventos> GetEventos();
        public Eventos? GetEvento(int id);
    }
}
