using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _000universe.Models; // Para poder usar la clase Event

namespace _000universe.Controllers
{
    public class ViewDataBagEventController : Controller
    {
        // GET: UniverseEvent
        public ActionResult Index()
        {
            ViewDataBagEventBusinessLayer universeEventBL = new ViewDataBagEventBusinessLayer();
            ViewDataBagEvent universeEvent = universeEventBL.GetUniverseEventById(1);

            // Pasar datos del controlador a la vista con ViewData
            // Solo es válido durante la solicitud actual
            ViewData["UniverseEvent"] = universeEvent;
            ViewData["Title"] = "Eventos Del Universo";

            ViewBag.UniverseEvent = universeEvent;
            ViewBag.Footer = "Proyecto Planck";

            return View();
        }
    }
}