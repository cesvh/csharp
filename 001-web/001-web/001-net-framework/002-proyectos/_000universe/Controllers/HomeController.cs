using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; // Hereda de Controller

namespace _000universe.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // https://localhost:44334/home/index: home -> index: / -> route default
        // En el archivo de clase RouteConfig.cs y verá que el método RegisterRoutes() de la clase RouteConfig tiene una ruta predeterminada
        public ActionResult Index()
        {
            return View();
        }

        // https://localhost:44334/home/indexid/29
        public string IndexId(int id)
        {
            return $"El valor del id es: {id}";
        }

        // https://localhost:44334/home/indexidstring/29?username=cesar
        public string IndexIdString(int id, string username) {
            return $"El valor del id es: {id} y del username es: {username}";
            //return "Id = " + id + " ,Name = " + Request.QueryString["username"]; // Otra opción de obtener el parámetro "username" del query
        }

        // La clase controlador contiene un conjunto de métodos públicos, también llamados métodos de acción. Estos métodos de acción gestionan las solicitudes HTTP entrantes.
        // En ASP.NET MVC, el nombre de cada clase de controlador debe terminar con la palabra "Controller".
        // Por ejemplo, si tiene una clase llamada "HomeController", el nombre del controlador en la URL será "Home".
        // Cada clase de controlador debe estar ubicada en la carpeta Controladores.

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ContactUs() {
            return View();
        }
    }
}