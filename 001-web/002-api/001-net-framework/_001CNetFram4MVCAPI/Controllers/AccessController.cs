using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _001CNetFram4MVCAPI.Models;
using _001CNetFram4MVCAPI.Models.WS;

namespace _001CNetFram4MVCAPI.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HelloWorld() {
            Reply reply = new Reply();
            try
            {
                reply.Result = 1;
                reply.Data = "Hello World!";
                reply.Message = "Success";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                reply.Result = 0;
                reply.Data = null;
                reply.Message = "Ocurrió un error";
            }
            return reply;
        }

        [HttpPost]
        public Reply Login([FromBody] AccessViewModel model)
        {
            Reply reply = new Reply();
            try
            {
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    var lst = db.tb_user.Where(x => x.email == model.email && x.password == model.password);
                    if (lst.Count() > 0) {
                        var user = lst.FirstOrDefault();
                        reply.Result = 1;
                        reply.Data = Guid.NewGuid().ToString();
                        reply.Message = "Login correcto";
                    }
                    else
                    {
                        reply.Result = 0;
                        reply.Data = null;
                        reply.Message = "Usuario o contraseña incorrectos";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                reply.Result = 0;
                reply.Data = null;
                reply.Message = "Ocurrió un error";
            }
            return reply;
        }
    }
}
