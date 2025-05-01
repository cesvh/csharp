using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _001CNetFram4MVCAPI.Models;

namespace _001CNetFram4MVCAPI.Controllers
{
    public class BaseController : ApiController
    {
        public string error = "";
        public bool Verify(string token)
        {
            try
            {
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    var user = db.tb_user.Where(x => x.token == token);
                    if (user.Count() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
