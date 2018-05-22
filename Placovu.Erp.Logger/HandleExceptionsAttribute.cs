using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Placovu.Erp.Logger
{
    public class HandleExceptionsAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception.GetBaseException();

            MethodBase site = exception.TargetSite;
            string methodName = site == null ? null : site.Name;

            ILog log = log4net.LogManager.GetLogger(methodName);
            log.Error("Error", exception);
            filterContext.HttpContext.ClearError();
        }
    }
}
