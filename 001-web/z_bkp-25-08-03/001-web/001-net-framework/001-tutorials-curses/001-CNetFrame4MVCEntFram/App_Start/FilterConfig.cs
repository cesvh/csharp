using System.Web;
using System.Web.Mvc;

namespace _001_CNetFrame4MVCEntFram
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.VerifySession());
        }
    }
}
