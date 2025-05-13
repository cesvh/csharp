﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _000universe.Models; // Para poder usar la clase Event

namespace _000universe.Models
{
    public class UniverseEventBusinessLayer
    {
        public UniverseEvent GetUniverseEventById(int id)
        {
            UniverseEvent universeEvent = new UniverseEvent()
            {
                Id = id,
                EventName = "Big Bang",
                EventYear = -13700000000,
                StandardDeviation = null, //300000000,
                ItemDescription = null, //"Expanción del universo",
                Active = 1
            };
            return universeEvent;
        }
    }
}