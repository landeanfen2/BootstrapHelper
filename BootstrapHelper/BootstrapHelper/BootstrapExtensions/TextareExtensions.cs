using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class TextareExtensions
    {
        /// <summary>
        /// textarea文本域
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <returns>html标签</returns>
        public static MvcHtmlString TextAreaBox(this BootstrapHelper html, string id)
        {
            return TextAreaBox(html, id, null, null, null, null);
        }

        /// <summary>
        /// textarea文本域
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">value</param>
        /// <param name="cssClass">样式</param>
        /// <returns>html标签</returns>
        public static MvcHtmlString TextAreaBox(this BootstrapHelper html, string id, object value, string cssClass)
        {
            return TextAreaBox(html, id, value, cssClass, null, null);
        }

        /// <summary>
        /// textarea文本域
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">value</param>
        /// <param name="cssClass">样式</param>
        /// <param name="rows">行数</param>
        /// <returns>html标签</returns>
        public static MvcHtmlString TextAreaBox(this BootstrapHelper html, string id, object value, string cssClass, int? rows)
        {
            return TextAreaBox(html, id, value, cssClass, rows, null);
        }

        /// <summary>
        /// textarea文本域
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">value</param>
        /// <param name="cssClass">样式</param>
        /// <param name="rows">行数</param>
        /// <param name="cols">列数</param>
        /// <returns>html标签</returns>
        public static MvcHtmlString TextAreaBox(this BootstrapHelper html, string id, object value, string cssClass, int? rows, int? cols)
        {
            TagBuilder tag = new TagBuilder("textarea");
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
            if (rows != null)
            {
                tag.MergeAttribute("rows", rows.ToString());
            }
            if (cols != null)
            {
                tag.MergeAttribute("cols", cols.ToString());
            }

            return MvcHtmlString.Create(tag.ToString());
        }
    }
}