using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Placovu.Erp.Web.Framework.DropDownList
{
    public static class YearDropDownListHelpers
    {
        public static MvcHtmlString YearDropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression, int min, int max, string selectedValue = null,
            string optionLabel = null, object htmlAttributes = null)
        {
            return YearDropDownListFor(htmlHelper, expression, min, max, null /*selectedValue*/, false, optionLabel , htmlAttributes);
        }

        public static MvcHtmlString YearDropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, int startYear, int maxRow, string selectedValue = null, bool obderbyDesc = false, string optionLabel = null, object htmlAttributes = null)
        {
            var newitems = Enumerable.Range(startYear - maxRow + 1, maxRow);
            if (!obderbyDesc)
            {
                newitems = newitems.Reverse();
            }
            var list = newitems.Select(x => new SelectListItem
            {
                Text = x.ToString(),
                Value = x.ToString(),
                Selected = (selectedValue == (x + 1).ToString())
            });

            var result = htmlHelper.DropDownListFor(expression, list, optionLabel, htmlAttributes);
            return result;
        }
    }
}
