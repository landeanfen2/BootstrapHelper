using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class RadioExtensions
    {
        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="name">name属性</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string name)
        {
            return Radio(html, null, name, null, null, null, false, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name)
        {
            return Radio(html, id, name, null, null, null, false, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="isCheck">是否选中</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, bool isCheck)
        {
            return Radio(html, id, name, null, null, null, isCheck, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value)
        {
            return Radio(html, id, name, value, null, null, false, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text)
        {
            return Radio(html, id, name, value, text, null, false, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <param name="isCheck">是否选中</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text, bool isCheck)
        {
            return Radio(html, id, name, value, text, null, isCheck, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <param name="labelClass">label标签的样式</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text, string labelClass)
        {
            return Radio(html, id, name, value, text, labelClass, false, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <param name="labelClass">label标签的样式</param>
        /// <param name="isCheck">是否选中</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text, string labelClass, bool isCheck)
        {
            return Radio(html, id, name, value, text, labelClass, isCheck, false, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <param name="labelClass">label标签的样式</param>
        /// <param name="isCheck">是否选中</param>
        /// <param name="isDisabled">是否禁用</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text, string labelClass, bool isCheck, bool isDisabled)
        {
            return Radio(html, id, name, value, text, labelClass, isCheck, isDisabled, null);
        }

        /// <summary>
        /// 返回表单radio标签
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="name">name属性</param>
        /// <param name="value">input的value值</param>
        /// <param name="text">显示文本</param>
        /// <param name="labelClass">label标签的样式</param>
        /// <param name="isCheck">是否选中</param>
        /// <param name="isDisabled">是否禁用</param>
        /// <param name="oAttributes">额外标签</param>
        /// <returns>返回radio标签</returns>
        public static MvcHtmlString Radio(this BootstrapHelper html, string id, string name, object value, string text, string labelClass, bool isCheck, bool isDisabled, object oAttributes)
        {
            IDictionary<string, object> htmlAttributes = null;
            if (oAttributes != null)
            {
                htmlAttributes = BootstrapHelper.AnonymousObjectToHtmlAttributes(oAttributes);
            }
            else
            {
                htmlAttributes = new Dictionary<string, object>();
            }
            return InputExtensions.CheckBox(html, InputType.Radio, id, name, value, text, labelClass, isCheck, isDisabled, htmlAttributes);
        }
    }
}