using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _000universe.Models;

namespace _000universe.Models.ViewModels
{
    public class EventDescriptionViewModel
    {
        public Event Event { get; set; }
        public EventDescription EventDescription { get; set; }
        public string PageTitle { get; set; }
        public string Footer { get; set; }
    }
}