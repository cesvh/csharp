using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _000universe.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public long EventYear { get; set; }
        public long? StandardDeviation { get; set; }
        public string ItemDescription { get; set; }
        public string DatetimeCreate { get; set; }
        public string TimestampUpdate { get; set; }
        public int? Active { get; set; }
    }
}