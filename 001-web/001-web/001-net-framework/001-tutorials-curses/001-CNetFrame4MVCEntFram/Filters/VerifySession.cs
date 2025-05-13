using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _001_CNetFrame4MVCEntFram.Controllers;
using _001_CNetFrame4MVCEntFram.Models;

namespace _001_CNetFrame4MVCEntFram.Filters
{
    public class VerifySession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var oUser = (tb_users)HttpContext.Current.Session["user"];
            if (oUser == null)
            {
                if ((filterContext.Controller is AccessController) == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Access/Index");
                }
            }
            else
            {
                if (filterContext.Controller is AccessController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
                base.OnActionExecuting(filterContext);
        }
    }
}