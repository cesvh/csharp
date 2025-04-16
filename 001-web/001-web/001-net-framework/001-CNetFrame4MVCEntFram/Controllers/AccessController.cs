using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _001_CNetFrame4MVCEntFram.Models;

namespace _001_CNetFrame4MVCEntFram.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using (t_cmvcEntities db = new t_cmvcEntities())
                {
                    var lst = from d in db.tb_users
                               where d.email == user && d.password == password && d.idState == 1
                               select d;
                    if (lst.Count() > 0)
                    {
                        Session["user"] = lst.First();
                    }
                }
                return Json(new { user, password });
            }
            catch (Exception ex)
            {
                return Content("Ocurrió un error: " + ex.Message);
            }
        }
    }
}