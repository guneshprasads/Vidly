using System.Web;
using System.Web.Mvc;

namespace Vidly_2nd_try
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
