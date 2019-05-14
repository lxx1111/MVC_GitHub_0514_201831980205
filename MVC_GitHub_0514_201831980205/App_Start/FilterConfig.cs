using System.Web;
using System.Web.Mvc;

namespace MVC_GitHub_0514_201831980205
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
