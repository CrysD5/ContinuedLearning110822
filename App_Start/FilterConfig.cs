using System.Web;
using System.Web.Mvc;

namespace ContinuedLearning110822
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
