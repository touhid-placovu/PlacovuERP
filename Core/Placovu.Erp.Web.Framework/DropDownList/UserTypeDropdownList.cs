using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Placovu.Erp.Core;
using Placovu.Erp.Core.Extensions;

namespace Placovu.Erp.Web.Framework.DropDownList
{
    public static class UserTypeDropDownListHelpers
    {

        public static MvcHtmlString UserTypeDropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string selectedValue, string optionLabel, bool includeSystemAdmin = false, object htmlAttributes = null)
        {
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = Enums.AppRoleEnum.PracticeAdmin.ToDisplayNameAttr(),
                    Value = Enums.AppRoleEnum.PracticeAdmin.ToInt().ToString()
                },
                new SelectListItem
                {
                    Text = Enums.AppRoleEnum.Scheduler.ToString(),
                    Value = Enums.AppRoleEnum.Scheduler.ToInt().ToString()
                },
                new SelectListItem
                {
                    Text = Enums.AppRoleEnum.Professional.ToString(),
                    Value = Enums.AppRoleEnum.Professional.ToInt().ToString()
                },
                new SelectListItem
                {
                    Text = Enums.AppRoleEnum.Patient.ToString(),
                    Value = Enums.AppRoleEnum.Patient.ToInt().ToString()
                },
                new SelectListItem
                {
                    Text = Enums.AppRoleEnum.OperatingRoomPersonnel.ToString(),
                    Value = Enums.AppRoleEnum.OperatingRoomPersonnel.ToInt().ToString()
                }
            };
            if (includeSystemAdmin)
            {
                items.Insert(0,
                    new SelectListItem
                    {
                        Text = Enums.AppRoleEnum.SystemAdmin.ToDisplayNameAttr(),
                        Value = Enums.AppRoleEnum.SystemAdmin.ToInt().ToString()
                    });
            }
            items.ForEach(x =>
            {
                x.Selected = (selectedValue == x.Value.ToInt().ToString());
            });

            var result = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)items, optionLabel, htmlAttributes);
            return result;
        }
    }
}
