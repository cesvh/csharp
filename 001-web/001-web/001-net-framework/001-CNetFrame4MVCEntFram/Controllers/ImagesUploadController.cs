using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _001_CNetFrame4MVCEntFram.Models.ViewModels;

namespace _001_CNetFrame4MVCEntFram.Controllers
{
    public class ImagesUploadController : Controller
    {
        // GET: ImagesUpload
        public ActionResult Index()
        {
            if (TempData["Mensaje"] != null) {
                ViewBag.Mensaje = TempData["Mensaje"].ToString();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(ImagesUploadViewModel model)
        {
            string RutaSitio = Server.MapPath("~/Files");
            string PathArchivo1 = Path.Combine(RutaSitio, model.File1.FileName);
            string PathArchivo2 = Path.Combine(RutaSitio, model.File2.FileName);
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            model.File1.SaveAs(PathArchivo1);
            model.File1.SaveAs(PathArchivo2);
            @TempData["Mensaje"] = "Archivos guardados correctamente";
            return RedirectToAction("Index");
        }
    }
}