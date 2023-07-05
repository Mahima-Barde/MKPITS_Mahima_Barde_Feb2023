using System.Web;
using System.Web.Mvc;

namespace Student_list_MVC_Insert
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
