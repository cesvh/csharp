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
                            where u.idState == 1
                            orderby u.email
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

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            EditUserViewModel userViewModel = new EditUserViewModel();
            using (t_cmvcEntities db = new t_cmvcEntities())
            {
                tb_users user = db.tb_users.Find(Id);
                if (user != null)
                {
                    userViewModel.Email = user.email;
                    userViewModel.Edad = user.edad ?? 0;
                    userViewModel.Id = user.id;
                }
            }
            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }
            using (t_cmvcEntities db = new t_cmvcEntities())
            {
                tb_users user = db.tb_users.Find(userViewModel.Id);
                user.email = userViewModel.Email;
                user.edad = userViewModel.Edad;
                if (userViewModel.Password != null && userViewModel.Password.Trim() != "")
                {
                    user.password = userViewModel.Password;
                }
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                //tb_users user = db.tb_users.Find(userViewModel.Id);
                //if (user != null)
                //{
                //    user.email = userViewModel.Email;
                //    user.edad = userViewModel.Edad;
                //    if (userViewModel.Password != null && !string.IsNullOrEmpty(userViewModel.Password))
                //    {
                //        user.password = userViewModel.Password;
                //    }
                //    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                //    db.SaveChanges();
                //}
            }
            return Redirect(Url.Content("~/User/"));
        }
    }
}