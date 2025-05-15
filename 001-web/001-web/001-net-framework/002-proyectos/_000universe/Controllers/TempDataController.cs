using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace _000universe.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["Header"] = "TempData Example";
            TempData["Footer"] = 29;
            return View();
        }

        public ActionResult PrimeraPeticion()
        {
            string header = "";
            int footer = 0;
            if (TempData["Header"] != null)
            {
                header = TempData["Header"].ToString();
            }
            if (TempData["Footer"] != null)
            {
                footer = (int)TempData["Footer"];
            }
            TempData.Keep(); // Mantener los valores de TempData para la siguiente petición
            ViewBag.Header = header;
            ViewBag.Footer = footer;
            return View();
        }

        public ActionResult SegundaPeticion()
        {
            string header = "";
            int footer = 0;
            if (TempData["Header"] != null)
            {
                header = TempData["Header"].ToString();
            }
            if (TempData["Footer"] != null)
            {
                footer = (int)TempData["Footer"];
            }
            ViewBag.Header = header;
            ViewBag.Footer = footer;
            return View();
        }
    }
}