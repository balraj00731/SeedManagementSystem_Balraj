using System.Web;
using System.Web.Mvc;

namespace SeedManagementSystem_Balraj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
