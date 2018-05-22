using Placovu.Erp.Logger;
using System.Web;
using System.Web.Mvc;

namespace Placovu.Erp.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());           
        }
    }
}
