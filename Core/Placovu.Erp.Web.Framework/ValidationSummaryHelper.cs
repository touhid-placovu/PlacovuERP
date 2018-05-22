using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web.Mvc
{
    public static class ValidationExtensions
    {
        public static MvcHtmlString FormatValidation(this MvcHtmlString alert)
        {
            if (alert == null)
                return MvcHtmlString.Empty;
            string alertData = alert.ToHtmlString();
            
            if (String.IsNullOrEmpty(alertData) && String.IsNullOrEmpty(alertData))
                return MvcHtmlString.Empty;
            return
                new MvcHtmlString(String.Format(
                    "<div class='alert alert-{0} alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>{1}</strong>{2}</div>",
                    "danger", HttpUtility.HtmlEncode(""), alertData));
        }
    }
}
