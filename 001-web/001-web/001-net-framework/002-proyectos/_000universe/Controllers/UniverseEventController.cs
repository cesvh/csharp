using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _000universe.Models; // Para poder usar la clase Event

namespace _000universe.Controllers
{
    public class UniverseEventController : Controller
    {
        // GET: UniverseEvent
        public ActionResult Index()
        {
            UniverseEventBusinessLayer universeEventBL = new UniverseEventBusinessLayer();
            UniverseEvent universeEvent = universeEventBL.GetUniverseEventById(1);
            return View();
        }
    }
}