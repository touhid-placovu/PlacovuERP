using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace System.Web.Mvc.Html
{
    public static class LabelExtensions
    {

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString RequiredLabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object htmlAttributes)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            var resolvedLabelText = metadata.DisplayName ?? metadata.PropertyName;
            if (!metadata.IsRequired)
            {
                return html.LabelFor(expression, resolvedLabelText, htmlAttributes);
            }
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            if (attributes == null)
            {
                return html.LabelFor(expression, resolvedLabelText, htmlAttributes);
            }

            const string requiredClass = "required-label";
            if (attributes.ContainsKey("class"))
            {
                var classList = attributes["class"].ToString().Split(' ').ToList();
                classList.Add(requiredClass);
                attributes["class"] = string.Join(" ", classList);
            }
            else
            {
                attributes.Add("class", requiredClass);
            }

            return html.LabelFor(expression, resolvedLabelText, attributes);
        }
    }
}
