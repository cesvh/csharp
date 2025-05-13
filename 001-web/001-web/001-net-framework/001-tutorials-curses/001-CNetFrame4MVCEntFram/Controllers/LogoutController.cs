using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_CNetFrame4MVCEntFram.Controllers
{
    public class LogoutController : Controller
    {
        public ActionResult Logout()
        {
            try
            {
                Session["user"] = null;
                return RedirectToAction("Index", "Access");
            }
            catch (Exception ex)
            {
                return Content("Ocurrió un error: " + ex.Message);
            }
        }
    }
}