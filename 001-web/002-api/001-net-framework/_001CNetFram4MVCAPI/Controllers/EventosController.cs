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
                    List<ListaEventosViewModel> lst = List(db);
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

        [HttpPost]
        public Reply Add([FromBody] EventosViewModel model)
        {
            Reply reply = new Reply
            {
                Data = null,
                Message = "Ocurrió un error, intente más tarde",
                Result = 0
            };
            try {
                if (!Verify(model.Token))
                {
                    reply.Message = "Token inválido";
                    return reply;
                }
                if (!Validate(model))
                {
                    reply.Message = error;
                    return reply;
                }
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    tb_eventos evento = new tb_eventos
                    {
                        evento = model.Evento,
                        anio = model.Anio,
                        idEstatus = 1
                    };
                    db.tb_eventos.Add(evento);
                    db.SaveChanges();

                    List<ListaEventosViewModel> lst = List(db);

                    reply.Result = 1;
                    reply.Data = lst;
                    reply.Message = "Evento agregado correctamente";
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                reply.Result = 0;
                reply.Data = null;
                reply.Message = "Ocurrió un error, intente más tarde";
            }
            return reply;
        }

        [HttpPut]
        public Reply Edit([FromBody] EventosViewModel model)
        {
            Reply reply = new Reply
            {
                Data = null,
                Message = "Ocurrió un error, intente más tarde",
                Result = 0
            };
            try
            {
                if (!Verify(model.Token))
                {
                    reply.Message = "Token inválido";
                    return reply;
                }
                if (!Validate(model))
                {
                    reply.Message = error;
                    return reply;
                }
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    tb_eventos tb_event = db.tb_eventos.Find(model.Id);
                    tb_event.evento = model.Evento;
                    tb_event.anio = model.Anio;
                    db.Entry(tb_event).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    List<ListaEventosViewModel> lst = List(db);

                    reply.Result = 1;
                    reply.Data = lst;
                    reply.Message = "Evento agregado correctamente";
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

        [HttpDelete]
        public Reply Delete([FromBody] EventosViewModel model)
        {
            Reply reply = new Reply
            {
                Data = null,
                Message = "Ocurrió un error, intente más tarde",
                Result = 0
            };
            try
            {
                if (!Verify(model.Token))
                {
                    reply.Message = "Token inválido";
                    return reply;
                }
                //if (!Validate(model))
                //{
                //    reply.Message = error;
                //    return reply;
                //}
                using (t_cmvcapiEntities db = new t_cmvcapiEntities())
                {
                    tb_eventos tb_event = db.tb_eventos.Find(model.Id);
                    tb_event.idEstatus = 0;
                    db.Entry(tb_event).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    List<ListaEventosViewModel> lst = List(db);

                    reply.Result = 1;
                    reply.Data = lst;
                    reply.Message = "Evento agregado correctamente";
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

        #region HELPERS

        private bool Validate(EventosViewModel model) {
            if (string.IsNullOrEmpty(model.Evento))
            {
                error = "El evento es requerido";
                return false;
            }  

            return true;
        }

        private List<ListaEventosViewModel> List(t_cmvcapiEntities db)
        {
            List<ListaEventosViewModel> lst = (from e in db.tb_eventos
                                               where e.idEstatus == 1
                                               orderby e.anio descending
                                               select new ListaEventosViewModel
                                               {
                                                   Id = e.id,
                                                   Evento = e.evento,
                                                   Anio = (Int64)e.anio
                                               }).ToList();
            return lst;
        }

        #endregion
    }
}
