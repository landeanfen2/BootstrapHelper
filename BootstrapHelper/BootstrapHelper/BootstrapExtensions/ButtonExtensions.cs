using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class ButtonExtensions
    {
        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon)
        {
            return Button(html, text, icon, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="type">按钮类型。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonType type)
        {
            return Button(html, text, icon, type, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="htmlAttributes">一个对象，其中包含要为该元素设置的 HTML 特性。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, object htmlAttributes)
        {
            return Button(html, text, icon, ButtonType.Button, htmlAttributes);
        }        

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="type">按钮类型。</param>
        /// <param name="htmlAttributes">一个对象，其中包含要为该元素设置的 HTML 特性。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonType type, object htmlAttributes)
        {
            return Button(html, text, icon, type, ButtonClass.Default, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="cssClass">按钮样式。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonClass cssClass)
        {
            return Button(html, text, icon, cssClass, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="cssClass">按钮样式。</param>
        /// <param name="htmlAttributes">一个对象，其中包含要为该元素设置的 HTML 特性。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonClass cssClass, object htmlAttributes)
        {
            return Button(html, text, icon, ButtonType.Button, cssClass, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">此方法扩展的 HTML 帮助器实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="type">按钮类型。</param>
        /// <param name="cssClass">按钮样式。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonType type, ButtonClass cssClass)
        {
            return Button(html, text, icon, type, cssClass, null);
        }

        /// <summary>
        /// 通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 Bootstrap Button 元素。
        /// </summary>
        /// <param name="html">扩展方法实例。</param>
        /// <param name="text">显示在按钮上的文本。</param>
        /// <param name="icon">图标的css类。</param>
        /// <param name="type">按钮类型。</param>
        /// <param name="cssClass">按钮样式。</param>
        /// <param name="htmlAttributes">一个对象，其中包含要为该元素设置的 HTML 特性。</param>
        /// <returns>一个 Bootstrap Button元素。</returns>
        public static MvcHtmlString Button(this BootstrapHelper html, string text, string icon, ButtonType type, ButtonClass cssClass, object htmlAttributes, ButtonSize size = ButtonSize.nm)
        {
            TagBuilder tag = new TagBuilder("button");
            IDictionary<string, object> attributes = BootstrapHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            attributes.Add("type", type.ToString().ToLower());
            tag.AddCssClass("btn btn-" + cssClass.ToString().ToLower());
            tag.MergeAttributes(attributes);
            TagBuilder span = new TagBuilder("span");
            span.AddCssClass(icon.Substring(0, icon.IndexOf('-')) + " " + icon);
            if (size != ButtonSize.nm)
            {
                tag.AddCssClass("btn-" + size.ToString());
            }
            span.Attributes.Add("aria-hidden", "true");
            tag.InnerHtml = span.ToString() + text;
            return MvcHtmlString.Create(tag.ToString());
        }
    }


    /// <summary>
    /// bootstrap按钮样式
    /// </summary>
    public enum ButtonClass
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Primary,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Danger,
        /// <summary>
        /// 
        /// </summary>
        Link
    }

    /// <summary>
    /// bootstrap按钮类型
    /// </summary>
    public enum ButtonType
    {
        /// <summary>
        /// 普通按钮
        /// </summary>
        Button,
        /// <summary>
        /// 提交按钮
        /// </summary>
        Submit,
        /// <summary>
        /// 重置按钮
        /// </summary>
        Reset
    }

    public enum ButtonSize
    { 
        lg,
        nm,
        sm,
        xs
    }
}