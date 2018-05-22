using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString RadioButtonAndLabelFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object value, string labelText)
        {
            return htmlHelper.RadioButtonAndLabelFor(expression, value, labelText, null);
        }
        public static MvcHtmlString RadioButtonAndLabelFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object value, string labelText, object htmlAttributes)
        {
            // Retrieve the qualified model identifier
            string name = ExpressionHelper.GetExpressionText(expression);
            string fullName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);

            // Generate the base ID
            TagBuilder tagBuilder = new TagBuilder("input");
            tagBuilder.GenerateId(fullName);
            string idAttr = tagBuilder.Attributes["id"];
            idAttr = String.Format("{0}_{1}", idAttr, value);
            string label_fp = "<label class=\"custom-radio-button\">";
            string label_sp = string.Format("<span class=\"helping-el\"></span><span class=\"custom-radio-button-label\">{0}</span></label>", labelText);
            // Create the individual HTML elements, using the generated ID
            MvcHtmlString radioButton = htmlHelper.RadioButtonFor(expression, value, htmlAttributes);

            return new MvcHtmlString(label_fp + radioButton.ToHtmlString() + label_sp);
        }
        public static MvcHtmlString CheckBoxAndLabelFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, string labelText, object htmlAttributes)
        {
            string label_fp = "<label class=\"custom-checkbox\">";
            string label_sp = string.Format("<span class=\"helping-el\"></span><span class=\"custom-checkbox-label\">{0}</span></label>", labelText);
            // Create the individual HTML elements, using the generated ID
            MvcHtmlString radioButton = htmlHelper.CheckBoxFor(expression, htmlAttributes);
            return new MvcHtmlString(label_fp + radioButton.ToHtmlString() + label_sp);
        }
        public static MvcHtmlString CheckBoxAndLabelFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            string label = htmlHelper.DisplayNameFor(expression).ToHtmlString();
            return CheckBoxAndLabelFor(htmlHelper, expression, label, htmlAttributes);
        }
        public static MvcHtmlString RadioButtonAndLabel(this HtmlHelper htmlHelper, string name, object value, string labelText, object htmlAttributes)
        {
            string template = "<label style=\"padding:0\" class=\"custom-radio-button\">{0}<span class=\"helping-el\"></span><span class=\"custom-radio-button-label\">{1}</span></label>";
            MvcHtmlString radioButton = htmlHelper.RadioButton(name, value, htmlAttributes);
            return new MvcHtmlString(string.Format(template, radioButton.ToHtmlString(), labelText));
        }
        public static MvcHtmlString RadioButtonAndLabelPMFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object value, string labelText , object htmlAttributes = null)
        {
            string radioId = "";
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            if (attributes.ContainsKey("id"))
            {
                radioId = attributes["id"].ToString();
            }
            if (labelText == "") labelText = "&nbsp;";
            MvcHtmlString label = htmlHelper.Label(radioId, labelText);
            MvcHtmlString radioButton = htmlHelper.RadioButtonFor(expression, value, htmlAttributes);            
            return new MvcHtmlString(string.Format(radioButton.ToHtmlString() + label));
        }
    }
}