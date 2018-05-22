using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class FlashHelpers
    {
        private static string TempDataString = "alert";
        public static ActionResult WithInfo(this ActionResult actionResult, ControllerBase controller, string title, string message, string tmpData, bool hideTitle)
        {
            AddMessageToTempData(controller, AlertType.Info, title, message, tmpData);
            return actionResult;
        }
        public static ActionResult WithInfo(this ActionResult actionResult, ControllerBase controller, string title, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Info, title, message, tmpData);
            return actionResult;
        }
        public static ActionResult WithInfo(this ActionResult actionResult, ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Info, "", message, tmpData);
            return actionResult;
        }
        public static ActionResult WithInfo(this ActionResult actionResult, ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Info, "", message);
            return actionResult;
        }
        public static ActionResult WithSuccess(this ActionResult actionResult, ControllerBase controller, string title , string message)
        {
            AddMessageToTempData(controller, AlertType.Success, title, message);
            return actionResult;
        }
        public static ActionResult WithSuccess(this ActionResult actionResult, ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Success, "", message);
            return actionResult;
        }
        public static ActionResult WithWarning(this ActionResult actionResult, ControllerBase controller, string title = "", string message = "")
        {
            AddMessageToTempData(controller, AlertType.Warning, title, message);
            return actionResult;
        }

        public static ActionResult WithError(this ActionResult actionResult, ControllerBase controller, string title, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Error, title, message);
            return actionResult;
        }
        public static ActionResult WithError(this ActionResult actionResult, ControllerBase controller, string message = "")
        {
            AddMessageToTempData(controller, AlertType.Error, "", message);
            return actionResult;
        }
        public static ActionResult WithError(this ActionResult actionResult, ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Error, "", message, tmpData);
            return actionResult;
        }
        public static void FlashInfo(this ControllerBase controller, string title , string message , string tmpData )
        {
            AddMessageToTempData(controller, AlertType.Info, title, message, string.IsNullOrEmpty(tmpData)?TempDataString: tmpData);
        }
        public static void FlashInfo(this ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Info, "", message, tmpData);
        }
        public static void FlashInfo(this ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Info, "", message, TempDataString);
        }
        public static void FlashSuccess(this ControllerBase controller, string title, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Success, title, message, tmpData);
        }
        public static void FlashSuccess(this ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Success, "", message, tmpData);
        }
        public static void FlashSuccess(this ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Success, "", message);
        }
      
        public static void FlashSuccessTD(this ControllerBase controller, string title = "", string message = "", string tmpData = "")
        {
            AddMessageToTempData(controller, AlertType.Success, title, message, tmpData);
        }
        public static void FlashWarning(this ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Warning, "", message);
        }
        public static void FlashWarning(this ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Warning, "", message, tmpData);
        }
        public static void FlashWarning(this ControllerBase controller, string title, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Warning, title , message, tmpData);
        }
        public static void FlashError(this ControllerBase controller, string message)
        {
            AddMessageToTempData(controller, AlertType.Error, "", message);
        }
        public static void FlashError(this ControllerBase controller, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Error, "", message, tmpData);
        }
        public static void FlashError(this ControllerBase controller, string title, string message, string tmpData)
        {
            AddMessageToTempData(controller, AlertType.Error, title, message, tmpData);
        }

        public static MvcHtmlString RenderAlertRaw(this HtmlHelper helper, string tempData = "")
        {
            object alertData = helper.ViewContext.TempData[tempData ?? TempDataString];
            if (alertData == null)
                return MvcHtmlString.Empty;
            var alert = new AlertMessage(alertData.ToString());
            return new MvcHtmlString(alert.Title);
        }

        public static MvcHtmlString RenderAlert(this HtmlHelper helper, string tempData)
        {
            object alertData = helper.ViewContext.TempData[tempData ?? TempDataString];

            if (alertData == null)
                return MvcHtmlString.Empty;

            var alert = new AlertMessage(alertData.ToString());

            if (String.IsNullOrEmpty(alert.Message) && String.IsNullOrEmpty(alert.Title))
                return MvcHtmlString.Empty;
            return
                new MvcHtmlString(String.Format(
                    "<div class='alert alert-{0} alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>{1}</strong>{2}</div>",
                    alert.CssClass, HttpUtility.HtmlEncode(alert.Title), HttpUtility.HtmlEncode(alert.Message)));
        }
        public static MvcHtmlString RenderAlert(this HtmlHelper helper)
        {
            return RenderAlert(helper, TempDataString);
        }
        public static MvcHtmlString RenderStaticAlertInfo(this HtmlHelper helper, string message)
        {
            if (string.IsNullOrEmpty(message) && string.IsNullOrEmpty(message))
                return MvcHtmlString.Empty;
            return
                new MvcHtmlString(string.Format(
                    "<div class='alert alert-{0} alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>{1}</strong>{2}</div>",
                    "info", "", HttpUtility.HtmlEncode(message)));
        }
        public static MvcHtmlString RenderStaticAlertWarning(this HtmlHelper helper, string message)
        {
            if (string.IsNullOrEmpty(message) && string.IsNullOrEmpty(message))
                return MvcHtmlString.Empty;
            return
                new MvcHtmlString(string.Format(
                    "<div class='alert alert-{0} alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>{1}</strong>{2}</div>",
                    "warning", "", HttpUtility.HtmlEncode(message)));
        }
        public static MvcHtmlString RenderAlert(this HtmlHelper helper, string message, string title ="", string cssclass = "success")
        {
            if (message == null)
                return MvcHtmlString.Empty;

            if (String.IsNullOrEmpty(message) && String.IsNullOrEmpty(title))
                return MvcHtmlString.Empty;
            return
                new MvcHtmlString(String.Format(
                    "<div class='alert alert-{0} alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>{1}</strong>{2}</div>",
                    cssclass, HttpUtility.HtmlEncode(title), HttpUtility.HtmlEncode(message)));
        }
        private static void AddMessageToTempData(ControllerBase controller, AlertType type, string title, string message)
        {
            var alertMessage = new AlertMessage
            {
                Title = title,
                Message = message,
                CssClass = type.CssClass
            };

            controller.TempData[TempDataString] = alertMessage.AsJson();
        }
        private static void AddMessageToTempData(ControllerBase controller, AlertType type, string title, string message, string tempData)
        {
            var alertMessage = new AlertMessage
            {
                Title = title,
                Message = message,
                CssClass = type.CssClass
            };

            controller.TempData[tempData] = alertMessage.AsJson();
        }
        internal class AlertType
        {
            public string CssClass { get; private set; }

            public AlertType(string cssClass)
            {
                CssClass = cssClass;
            }

            public static AlertType Success = new AlertType("success");
            public static AlertType Info = new AlertType("info");
            public static AlertType Warning = new AlertType("warning");
            public static AlertType Error = new AlertType("danger");
        }

        internal class AlertMessage
        {
            public string Title { get; set; }
            public string Message { get; set; }
            public string CssClass { get; set; }

            public AlertMessage() { }
            public AlertMessage(string json)
            {
                var alertMessage = JsonConvert.DeserializeObject<AlertMessage>(json);

                Title = alertMessage.Title;
                Message = alertMessage.Message;
                CssClass = alertMessage.CssClass;
            }

            public string AsJson()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
    }
}