using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_CNetFrame4MVCEntFram.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            using (var db = new Models.t_cmvcEntities())
            {
                lst = (from d in db.tb_class
                       select new SelectListItem
                       {
                           Value = d.id.ToString(),
                           Text = d.name
                       }).ToList();
                //var _class = db.tb_class.ToList();
                //foreach (var _cls in _class)
                //{
                //    lst.Add(new SelectListItem
                //    {
                //        Text = _cls.name,
                //        Value = _cls.id.ToString()
                //    });
                //}
            }
            return View(lst);
        }

        [HttpGet]
        public JsonResult Animal(int IdAnimalClass)
        {
            List<ElementJsonIntKey> lst = new List<ElementJsonIntKey>();
            using (var db = new Models.t_cmvcEntities())
            {
                lst = (from d in db.tb_animal
                       where d.idAnimal_Class == IdAnimalClass
                       select new ElementJsonIntKey
                       {
                           Value = d.id,
                           Text = d.name
                       }).ToList();
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }

    public class ElementJsonIntKey
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }
}