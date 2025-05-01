using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _001CNetFram4MVCAPI.Models.WS;
using _001CNetFram4MVCAPI.Models;

namespace _001CNetFram4MVCAPI.Controllers
{
    public class EventosController : BaseController
    {
        [HttpPost]
        public Reply Get([FromBody] SecurityViewModel model)
        {
            Reply reply = new Reply();
            reply.Data = null;
            reply.Message = "Ocurrió un error, intente más tarde";
            reply.Result = 0;
            if (!Verify(model.Token))
            {
                reply.Message = "Token inválido";
                return reply;
            }
            try
            {
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    List<ListaEventosViewModel> lst = (from e in db.tb_eventos
                                                       where e.idEstatus == 1
                                                       select new ListaEventosViewModel
                                                       {
                                                           Evento = e.evento,
                                                           Anio = (Int64)e.anio
                                                       }).ToList();
                    reply.Data = lst;
                    reply.Result = 1;
                    reply.Message = "Lista de eventos obtenida correctamente";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                reply.Result = 0;
                reply.Data = null;
                reply.Message = "Ocurrió un error, intente más tarde";
            }
            return reply;
        }
    }
}
