using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace BootstrapExtensions
{
    /// <summary>
    /// bootstrap TextBox文本框的所有扩展
    /// </summary>
    public static class TextBoxExtensions
    {
        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">表单元素的name属性值</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string name)
        {
            return InputExtensions.Helper(html, InputType.Text, null, name, null, false, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">表单元素的name属性值</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string id, string name)
        {
            return InputExtensions.Helper(html, InputType.Text, id, name, null, false, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">单元素的name属性值</param>
        /// <param name="value">表单元素的value值</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string id, string name, object value)
        {
            return InputExtensions.Helper(html, InputType.Text, id, name, value, false, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">单元素的name属性值</param>
        /// <param name="value">表单元素的value值</param>
        /// <param name="placeholder">bootstrap自带的文本框的提示输入值</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string id, string name, object value, string placeholder)
        {
            IDictionary<string, object> attributes = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(placeholder))
            {
                attributes.Add("placeholder", placeholder);
            }
            return InputExtensions.Helper(html, InputType.Text, id, name, value, false, attributes);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">单元素的name属性值</param>
        /// <param name="value">表单元素的value值</param>
        /// <param name="htmlAttributes">额外属性</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string id, string name, object value, object htmlAttributes)
        {
            IDictionary<string, object> attributes = BootstrapHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            return InputExtensions.Helper(html, InputType.Text, id, name, value, false, attributes);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本框标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">表单元素的name属性值</param>
        /// <param name="value">表单元素的value值</param>
        /// <param name="placeholder">bootstrap自带的文本框的提示输入值</param>
        /// <param name="htmlAttributes">额外属性</param>
        /// <returns>返回input type='text'标签</returns>
        public static MvcHtmlString TextBox(this BootstrapHelper html, string id, string name, object value, string placeholder, object htmlAttributes)
        {
            IDictionary<string, object> attributes = BootstrapHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            if (!string.IsNullOrEmpty(placeholder))
            {
                attributes.Add("placeholder", placeholder);
            }
            return InputExtensions.Helper(html, InputType.Text, id, name, value, false, attributes);
        }

        public static MvcHtmlString TextBoxFor<TModel, TProperty>(this BootstrapHelper<TModel> html, Expression<Func<TModel, TProperty>> expression)
        {
            var model = (TModel)html.ViewData.Model;
            string propertyName;
            object value;
            InputExtensions.GetValueByExpression<TModel, TProperty>(expression, model, out propertyName, out value);
           return InputExtensions.Helper(html, InputType.Text, propertyName, propertyName, value, false, null);
        }

    }
}