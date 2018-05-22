using log4net;
using Placovu.Erp.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Placovu.Erp.Web.Framework
{
    /// <summary>
    /// Base controller
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
           
            string controller = "Controller/";
            string action = "Action/";
            var context = filterContext.HttpContext.Request.RequestContext;
            var routeValues = filterContext.HttpContext.Request.RequestContext.RouteData.Values;
            if (routeValues.ContainsKey("controller"))
                controller = (string)routeValues["controller"];
            if (routeValues.ContainsKey("action"))
                action = (string)routeValues["action"];
            
            var exception = filterContext.Exception.GetBaseException();

            HttpException httpException = exception as HttpException;
            int httpExceptionCode = httpException.GetHttpCode();

            string methodName = controller + "=>" +  action;
            ILog log = LogManager.GetLogger(methodName);
            if(exception.InnerException != null)
            {
                log.Error("Error: " + exception.InnerException.Message);
            }
            else if(exception != null)
            {
                log.Error("Error: " + exception.Message);
            }
            filterContext.ExceptionHandled = true;

            Server.ClearError();
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new JsonResult()
                {
                    ContentType = "application/json",
                    Data = new
                    {
                        name = filterContext.Exception.GetType().Name,
                        message = filterContext.Exception.Message,
                        callstack = filterContext.Exception.StackTrace
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
                
                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            }
            else
            {
                Response.Redirect(Url.Action("Index", "ErrorHandler", new { Area = "" }));
            }
            //else
            //{
            //    var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "ErrorHandler", new { Area = "" });
            //    filterContext.HttpContext.Response.StatusCode = 500;
            //    filterContext.HttpContext.Response.Write(new JavaScriptSerializer().Serialize(new { error = MessageConstant.ErrorCommon, url = redirectUrl }));
            //}
        }
    }
}