using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _001CNetFram4MVCAPI.Models.WS
{
    public class EventosViewModel : SecurityViewModel
    {
        public int Id { get; set; }
        public string Evento { get; set; }
        public Int64 Anio { get; set; }
    }
}