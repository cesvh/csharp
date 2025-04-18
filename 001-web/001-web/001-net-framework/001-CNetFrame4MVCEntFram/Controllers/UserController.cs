using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _001_CNetFrame4MVCEntFram.Models;
using _001_CNetFrame4MVCEntFram.Models.TableViewModels;
using _001_CNetFrame4MVCEntFram.Models.ViewModels;

namespace _001_CNetFrame4MVCEntFram.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserTableViewModels> userList = null;
            using (t_cmvcEntities db = new t_cmvcEntities())
            {
                userList = (from u in db.tb_users
                       select new UserTableViewModels
                       {
                           Id = u.id,
                           Email = u.email,
                           Edad = u.edad
                       }).ToList();
            }
            return View(userList);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }
            tb_users user = new tb_users
            {
                email = userViewModel.Email,
                password = userViewModel.Password,
                idState = 1,
                edad = userViewModel.Edad
            };
            using (t_cmvcEntities db = new t_cmvcEntities())
            {
                db.tb_users.Add(user);
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/User/"));
        }
    }
}