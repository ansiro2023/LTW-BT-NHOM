using System.Web;
using System.Web.Mvc;

namespace WEBSITE_BAN_HANG_LAPTOP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
