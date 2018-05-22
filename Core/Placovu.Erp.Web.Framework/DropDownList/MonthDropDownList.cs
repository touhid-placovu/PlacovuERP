using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Placovu.Erp.Web.Framework
{
    public static class MonthDropDownListHelpers
    {
        
        public static MvcHtmlString MonthDropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string selectedValue, string optionLabel, object htmlAttributes = null)
        {
           
            var newitems = DateTimeFormatInfo.InvariantInfo.MonthNames.AsEnumerable().Where(x=> x != "");
            var list = newitems.Select((monthName, index) => new SelectListItem
                {
                    Value = (index + 1).ToString(),
                    Text = monthName,
                    Selected = (selectedValue == (index + 1).ToString())
                });

            var result = htmlHelper.DropDownListFor(expression, list, optionLabel, htmlAttributes);
            return result;
        }
    }
}
