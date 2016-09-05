using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    /// <summary>
    /// Bootstrap表单元素Input扩展方法集合
    /// </summary>
    public static class InputExtensions
    {
        public static MvcHtmlString Helper(BootstrapHelper html, InputType inputType, string id, string name,  object value, bool isCheck, IDictionary<string, object> htmlAttributes)
        {
            //定义标签的名称
            TagBuilder tag = new TagBuilder("input");
            if (htmlAttributes == null)
            {
                htmlAttributes = new Dictionary<string, object>();
            }
            //添加name
            if (!string.IsNullOrEmpty(name))
            {
                htmlAttributes.Add("name", name);
            }
            //添加id
            if (!string.IsNullOrEmpty(id))
            {
                htmlAttributes.Add("id", id);
            }
            //添加value
            if (value != null)
            {
                htmlAttributes.Add("value", value.ToString());
            }
            //添加input的类型
            tag.MergeAttribute("type", HtmlHelper.GetInputTypeString(inputType));
            //添加默认样式
            tag.AddCssClass("form-control");
            tag.MergeAttributes(htmlAttributes);

            if (inputType == InputType.Radio || inputType == InputType.CheckBox)
            {
                if (isCheck) 
                    tag.MergeAttribute("checked", "checked");
            }
            return MvcHtmlString.Create(tag.ToString());
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
        public static MvcHtmlString CheckBox(BootstrapHelper html, InputType inputType, string id, string name, object value, string text, string labelClass, bool isCheck, bool isDisabled, IDictionary<string, object> htmlAttributes)
        {
            //定义标签的名称
            TagBuilder tag = new TagBuilder("label");
            if (!string.IsNullOrEmpty(labelClass))
            {
                htmlAttributes.Add("class", labelClass);
            }
            System.Text.StringBuilder sbInput = new System.Text.StringBuilder();
            var strInputType = HtmlHelper.GetInputTypeString(inputType);
            sbInput.Append("<input type='").Append(strInputType).Append("'");
            if (!string.IsNullOrEmpty(name))
            {
                sbInput.Append(" name = '").Append(name).Append("'");
            }
            if (!string.IsNullOrEmpty(id))
            {
                sbInput.Append(" id = '").Append(id).Append("'");
            }
            if (value != null)
            {
                sbInput.Append(" value = '").Append(value.ToString()).Append("'");
            }
            if (isCheck)
            {
                sbInput.Append(" checked = 'checked'");
            }
            if (isDisabled)
            {
                sbInput.Append(" disabled");
            }
            sbInput.Append(" />");
            if (!string.IsNullOrEmpty(text))
            {
                sbInput.Append(text);
            }
            tag.InnerHtml = sbInput.ToString();

            tag.MergeAttributes(htmlAttributes);
            return MvcHtmlString.Create(tag.ToString());
        }

        //通过表达式取当前的属性值
        public static void GetValueByExpression<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, TModel model, out string propertyName, out object value)
        {
            MemberExpression body = (MemberExpression)expression.Body;
            var lamadaName = (body.Member is PropertyInfo) ? body.Member.Name : null;
            propertyName = lamadaName;

            value = null;
            System.Reflection.PropertyInfo[] lstPropertyInfo = typeof(TModel).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var oFind = lstPropertyInfo.FirstOrDefault(x => x.Name == lamadaName);
            if (oFind != null)
            {
                value = oFind.GetValue(model, null);
            }
        }
    }
}