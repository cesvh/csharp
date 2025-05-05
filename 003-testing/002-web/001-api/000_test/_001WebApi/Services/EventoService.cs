using _001WebApi.Models;

namespace _001WebApi.Services
{
    public class EventoService : IEventos
    {
        private List<Eventos> _eventos = new List<Eventos>(){
            new Eventos()
            {
                Id = 1,
                Evento = "Gran expanción",
                Descripcion = "Inicio del universo"
            },
            new Eventos()
            {
                Id = 2,
                Evento = "Formación de los primeros átomos",
                Descripcion = ""
            },
            new Eventos()
            {
                Id = 3,
                Evento = "Formación de las primeras estrellas",
                Descripcion = ""
            }
        };

        public IEnumerable<Eventos> GetEventos() => _eventos;

        public Eventos? GetEvento(int id) => _eventos.FirstOrDefault(e => e.Id == id);
    }
}
