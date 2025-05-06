using _001WebApi.Controllers;
using _001WebApi.Models;
using _001WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace _001WebApixUnitTest
{
    public class EventoTesting
    {
        private readonly EventoController _controller;
        private readonly IEventoService _service;

        public EventoTesting()
        {
            _service = new EventoService();
            _controller = new EventoController(_service);
        }

        [Fact]
        public void Get_OK()
        {
            var result = _controller.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Quantity() {
            var result = _controller.Get();
            var okResult = result as OkObjectResult;
            var eventos = okResult?.Value as List<Eventos>;
            Assert.True(eventos?.Count > 0);
        }

        [Fact]
        public void GetById_Ok()
        {
            int Id = 1;
            var result = _controller.GetById(Id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Exists()
        {
            // Preparaci�n
            int Id = 1;

            // Ejecuci�n
            var result = (OkObjectResult)_controller.GetById(Id);

            // Verificaci�n
            var evento = Assert.IsType<Eventos>(result?.Value);
            Assert.True(evento != null);
            Assert.Equal(evento?.Id, Id);
        }

        [Fact]
        public void GetById_NotFound()
        {
            // Preparaci�n
            int Id = -1;

            // Ejecuci�n
            var result = _controller.GetById(Id);

            // Verificaci�n
            Assert.IsType<NotFoundResult>(result);
        }
    }
}