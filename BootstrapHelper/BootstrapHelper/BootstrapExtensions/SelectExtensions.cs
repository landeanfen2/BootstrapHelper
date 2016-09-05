using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class SelectExtensions
    {
        /// <summary>
        /// 返回select标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签id</param>
        /// <returns>select标签</returns>
        public static MvcHtmlString SelectBox(this BootstrapHelper html, string id)
        {
            return SelectBox(html, id, null, null, null, null, null, null);
        }

        /// <summary>
        /// 返回select标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签id</param>
        /// <param name="value">标签选中值</param>
        /// <returns>select标签</returns>
        public static MvcHtmlString SelectBox(this BootstrapHelper html, string id, object value)
        {
            return SelectBox(html, id, value, null, null, null, null, null);
        }

        /// <summary>
        /// 返回select标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签id</param>
        /// <param name="value">标签选中值</param>
        /// <param name="cssClass">标签样式</param>
        /// <returns>select标签</returns>
        public static MvcHtmlString SelectBox(this BootstrapHelper html, string id, object value, string cssClass)
        {
            return SelectBox(html, id, value, cssClass, null, null, null, null);
        }

        /// <summary>
        /// 返回select标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签id</param>
        /// <param name="value">标签选中值</param>
        /// <param name="cssClass">标签样式</param>
        /// <param name="url">请求数据的url</param>
        /// <param name="textField">显示字段</param>
        /// <param name="valueField">值字段</param>
        /// <returns>select标签</returns>
        public static MvcHtmlString SelectBox(this BootstrapHelper html, string id, object value, string cssClass, string url, string textField, string valueField)
        {
            return SelectBox(html, id, value, cssClass, url, null, textField, valueField);
        }

        /// <summary>
        /// 返回select标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签id</param>
        /// <param name="value">标签选中值</param>
        /// <param name="cssClass">标签样式</param>
        /// <param name="url">请求数据的url</param>
        /// <param name="param">请求的参数</param>
        /// <param name="textField">显示字段</param>
        /// <param name="valueField">值字段</param>
        /// <param name="multiple">是否多选</param>
        /// <returns>select标签</returns>
        public static MvcHtmlString SelectBox(this BootstrapHelper html, string id, object value, string cssClass, string url, string param, string textField, string valueField, bool multiple = false)
        {
            TagBuilder tag = new TagBuilder("select");
            tag.AddCssClass("form-control");
            if (!string.IsNullOrEmpty(id))
            {
                tag.MergeAttribute("id", id);
            }
            if (value != null)
            {
                tag.MergeAttribute("value", value.ToString());
            }
            if (!string.IsNullOrEmpty(cssClass))
            {
                tag.AddCssClass(cssClass);
            }
            if (!string.IsNullOrEmpty(url))
            {
                tag.MergeAttribute("data-url", url);
            }
            if (!string.IsNullOrEmpty(param))
            {
                tag.MergeAttribute("data-param", param);
            }
            if (!string.IsNullOrEmpty(valueField))
            {
                tag.MergeAttribute("data-value-field", valueField);
            }
            if (!string.IsNullOrEmpty(textField))
            {
                tag.MergeAttribute("data-text-field", textField);
            }
            if (multiple)
            {
                tag.MergeAttribute("multiple", "multiple");
            }

            return MvcHtmlString.Create(tag.ToString());
        }
    }
}