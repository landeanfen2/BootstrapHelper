using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class DateTimeBoxExtensions
    {
        /// <summary>
        /// 生成日期控件
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">文本框标签的id</param>
        /// <returns>返回呈现日期控件的html标签</returns>
        public static MvcHtmlString DateTimeBox(this BootstrapHelper html, string id)
        {
            return DateTimeBox(html, id, null, null, null, null, null, null);
        }

        /// <summary>
        /// 生成日期控件
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">文本框标签的id</param>
        /// <param name="value">文本框标签的默认值</param>
        /// <returns>返回呈现日期控件的html标签</returns>
        public static MvcHtmlString DateTimeBox(this BootstrapHelper html, string id, object value)
        {
            return DateTimeBox(html, id, value, null, null, null, null, null);
        }

        /// <summary>
        /// 生成日期控件
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">文本框标签的id</param>
        /// <param name="value">文本框标签的默认值</param>
        /// <param name="format">显示日期的格式</param>
        /// <param name="maxDate">日期的最小值</param>
        /// <param name="minDate">日期的最大值</param>
        /// <returns>返回呈现日期控件的html标签</returns>
        public static MvcHtmlString DateTimeBox(this BootstrapHelper html, string id, object value, string format, string maxDate, string minDate)
        {
            return DateTimeBox(html, id, value, format, maxDate, minDate, null, null);
        }

        /// <summary>
        /// 生成日期控件
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">文本框标签的id</param>
        /// <param name="value">文本框标签的默认值</param>
        /// <param name="format">显示日期的格式</param>
        /// <param name="maxDate">日期的最小值</param>
        /// <param name="minDate">日期的最大值</param>
        /// <param name="viewMode">日期控件的浏览模式</param>
        /// <param name="showClear">是否显示清空按钮</param>
        /// <returns>返回呈现日期控件的html标签</returns>
        public static MvcHtmlString DateTimeBox(this BootstrapHelper html, string id, object value, string format, string maxDate, string minDate, string viewMode, bool? showClear)
        {
            TagBuilder tag = new TagBuilder("div");
            tag.MergeAttribute("class", "input-group date");
            if (!string.IsNullOrEmpty(format))
            {
                tag.MergeAttribute("data-format", format);
            }
            if (!string.IsNullOrEmpty(maxDate))
            {
                tag.MergeAttribute("data-maxDate", maxDate);
            }
            if (!string.IsNullOrEmpty(minDate))
            {
                tag.MergeAttribute("data-minDate", minDate);
            }
            if (!string.IsNullOrEmpty(viewMode))
            {
                tag.MergeAttribute("data-viewMode", viewMode);
            }
            if (showClear!=null)
            {
                tag.MergeAttribute("data-showClear", showClear.ToString());
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<input type='text' class='form-control'");
            if(!string.IsNullOrEmpty(id))
            {
                sb.Append("id='").Append(id).Append("' ");
            }
            if (value != null)
            {
                sb.Append("value='").Append(value.ToString()).Append("' ");
            }

            sb.Append("/>").Append("<span class='input-group-addon'>")
              .Append("<span class='glyphicon glyphicon-calendar'></span>")
              .Append("</span>");

            tag.InnerHtml = sb.ToString();

            return MvcHtmlString.Create(tag.ToString());
        }
    }
}