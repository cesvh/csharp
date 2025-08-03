using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _001CNetFram4MVCAPI.Models.WS
{
    public class Reply
    {
        public int Result { set; get; }
        public object Data { set; get; }
        public string Message { set; get; }
    }
}