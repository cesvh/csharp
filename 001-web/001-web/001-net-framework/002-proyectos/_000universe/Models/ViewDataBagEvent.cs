﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _000universe.Models
{
    public class ViewDataBagEvent
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public long EventYear { get; set; }
        public long? StandardDeviation { get; set; }
        public string ItemDescription { get; set; }
        public int Active { get; set; }

    }
}