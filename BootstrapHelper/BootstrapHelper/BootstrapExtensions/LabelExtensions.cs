using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    /// <summary>
    /// Bootstrap label标签的扩展方法
    /// </summary>
    public static class LabelExtensions
    {
        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回Label标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签的id</param>
        /// <returns>label标签的html字符串</returns>
        public static MvcHtmlString Label(this BootstrapHelper html, string id)
        {
            return Label(html, id, null, null, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回Label标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="content">标签的显示文本</param>
        /// <returns>label标签的html字符串</returns>
        public static MvcHtmlString Label(this BootstrapHelper html, object content)
        {
            return Label(html, null, content, null, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回Label标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签的id</param>
        /// <param name="content">标签的显示文本</param>
        /// <returns>label标签的html字符串</returns>
        public static MvcHtmlString Label(this BootstrapHelper html, string id, object content)
        {
            return Label(html, id, content, null, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回Label标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签的id</param>
        /// <param name="content">标签的显示文本</param>
        /// <param name="htmlAttributes">标签的额外属性（如果属性里面含有“-”，请用“_”代替）</param>
        /// <returns>label标签的html字符串</returns>
        public static MvcHtmlString Label(this BootstrapHelper html, string id, object content, object htmlAttributes)
        {
            return Label(html, id, content, null, htmlAttributes);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回Label标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">标签的id</param>
        /// <param name="content">标签的内容</param>
        /// <param name="cssClass">标签的class样式</param>
        /// <param name="htmlAttributes">标签的额外属性（如果属性里面含有“-”，请用“_”代替）</param>
        /// <returns>label标签的html字符串</returns>
        public static MvcHtmlString Label(this BootstrapHelper html, string id, object content, string cssClass, object htmlAttributes)
        {
            //定义标签的名称
            TagBuilder tag = new TagBuilder("label");
            //给标签增加额外的属性
            IDictionary<string, object> attributes = BootstrapHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            if (!string.IsNullOrEmpty(id))
            {
                attributes.Add("id", id);
            }
            if (!string.IsNullOrEmpty(cssClass))
            {
                //给标签增加样式
                tag.AddCssClass(cssClass);
            }
            //给标签增加文本
            tag.SetInnerText(content.ToString());
            tag.AddCssClass("control-label");
            tag.MergeAttributes(attributes);
            return MvcHtmlString.Create(tag.ToString());
        }
    }
}