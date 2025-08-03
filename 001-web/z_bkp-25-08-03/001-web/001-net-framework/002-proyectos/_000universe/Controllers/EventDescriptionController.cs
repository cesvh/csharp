using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _000universe.Models.BusinessLayer;
using _000universe.Models.ViewModels;

namespace _000universe.Controllers
{
    public class EventDescriptionController : Controller
    {
        // GET: EventDescription
        public ActionResult Index()
        {
            EventDescriptionBusinessLayer eventDescriptionBL = new EventDescriptionBusinessLayer();
            EventDescriptionViewModel eventDescriptionVM = eventDescriptionBL.GetEventDescriptionById(1);

            return View(eventDescriptionVM);
        }

        // url: "EventDescription/Secreto". En App_Start/RouteConfig.cs
        public string CustomRoute() {
            return "Método/Acción de la ruta personalizada";
        }
    }
}