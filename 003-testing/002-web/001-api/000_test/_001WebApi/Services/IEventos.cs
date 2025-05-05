using _001WebApi.Models;

namespace _001WebApi.Services
{
    public interface IEventos
    {
        public IEnumerable<Eventos> GetEventos();
        public Eventos? GetEvento(int id);
    }
}
