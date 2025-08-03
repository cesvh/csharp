using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _000universe.Models.ViewModels;

namespace _000universe.Models.BusinessLayer
{
    public class EventDescriptionBusinessLayer
    {
        public EventDescriptionViewModel GetEventDescriptionById(int id)
        {
            EventDescriptionViewModel eventDescriptionViewModel = new EventDescriptionViewModel()
            {
                Event = new Event()
                {
                    Id = id,
                    EventName = "Big Bang",
                    EventYear = -13700000000,
                    StandardDeviation = null, //300000000,
                    ItemDescription = null, //"Expanción del universo",
                    DatetimeCreate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    TimestampUpdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Active = 1
                },
                EventDescription = new EventDescription()
                {
                    Id = id,
                    FkIdEvent = id,
                    ItemDescription = "Expansión del universo",
                    DatetimeCreate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    TimestampUpdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Active = 1
                },
                PageTitle = "Eventos Del Universo",
                Footer = "Proyecto Planck"
            };
            return eventDescriptionViewModel;
        }
    }
}