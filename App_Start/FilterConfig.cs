using System.Web;
using System.Web.Mvc;

namespace HolaMundo_MVC_1173901
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
