using System.Web;
using System.Web.Mvc;

namespace MovieRental
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Global authorization
            filters.Add(new AuthorizeAttribute());
            //Cannot access via http://
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
