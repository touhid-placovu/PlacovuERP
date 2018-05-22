using System;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Placovu.Erp.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();            
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Enable xml configuration file for log4net
            var configFile = ConfigurationManager.AppSettings.Get("log4net.Config");
            if (!string.IsNullOrEmpty(configFile))
            {
                configFile = Environment.ExpandEnvironmentVariables(configFile);
                log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(@configFile));
            }
        }
        protected void Application_BeginRequest()
        {
            if (!HttpContext.Current.IsDebuggingEnabled)
            {
                if (!Context.Request.IsSecureConnection)
                    Response.Redirect(Context.Request.Url.ToString().Replace("http:", "https:"));
            }
        }
    }
}
