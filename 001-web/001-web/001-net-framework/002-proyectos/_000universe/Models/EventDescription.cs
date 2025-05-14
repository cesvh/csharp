using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _000universe.Models
{
    public class EventDescription
    {
        public int Id { get; set; }
        public int FkIdEvent { get; set; }
        public string ItemDescription { get; set; }
        public string DatetimeCreate { get; set; }
        public string TimestampUpdate { get; set; }
        public int? Active { get; set; }
    }
}