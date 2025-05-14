using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _000universe.Models;

namespace _000universe.Controllers
{
    public class StrongTypedEventController : Controller
    {
        // GET: StrongTypedEvent
        public ActionResult Index()
        {
            ViewDataBagEventBusinessLayer universeEventBL = new ViewDataBagEventBusinessLayer();
            ViewDataBagEvent universeEvent = universeEventBL.GetUniverseEventById(1);
            ViewBag.Encabezado = "Eventos Del Universo";
            ViewBag.Pie = "Proyecto Planck";

            return View(universeEvent);
        }
    }
}