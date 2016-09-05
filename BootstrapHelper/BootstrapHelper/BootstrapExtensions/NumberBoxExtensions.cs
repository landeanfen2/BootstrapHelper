using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapExtensions
{
    public static class NumberBoxExtensions
    {
        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, string id)
        {
            return NumberTextBox(html, id, null, null, null, null, null);
        }

        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">文本框的value值</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, string id, object value)
        {
            return NumberTextBox(html, id, value, null, null, null, null);
        }

        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="value">文本框的value值</param>
        /// <param name="min">自增长的最小值</param>
        /// <param name="max">自增长的最大值</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, object value, int? min, int? max)
        {
            return NumberTextBox(html, null, value, min, max, null, null);
        }

        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">文本框的value值</param>
        /// <param name="min">自增长的最小值</param>
        /// <param name="max">自增长的最大值</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, string id, object value, int? min, int? max)
        {
            return NumberTextBox(html, id, value, min, max, null, null);
        }

        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">文本框的value值</param>
        /// <param name="min">自增长的最小值</param>
        /// <param name="max">自增长的最大值</param>
        /// <param name="step">每次自增的数字</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, string id, object value, int? min, int? max, int? step)
        {
            return NumberTextBox(html, id, value, min, max, step, null);
        }

        /// <summary>
        /// 生成数字文本框
        /// </summary>
        /// <param name="html">扩展方法实例</param>
        /// <param name="id">id</param>
        /// <param name="value">文本框的value值</param>
        /// <param name="min">自增长的最小值</param>
        /// <param name="max">自增长的最大值</param>
        /// <param name="step">每次自增的数字</param>
        /// <param name="rule">自增规则</param>
        /// <returns>返回数字文本框</returns>
        public static MvcHtmlString NumberTextBox(this BootstrapHelper html, string id, object value, int? min, int? max, int? step, SpinningRule? rule)
        {
            TagBuilder tag = new TagBuilder("div");
            tag.MergeAttribute("class", "input-group spinner");
            tag.MergeAttribute("data-trigger", "spinner");

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.Append("<input type='text' class='form-control text-center' value='1' data-min='-10' data-max='10' data-step='2' data-rule='quantity'>");
            sb.Append("<input type='text' class='form-control text-center' ");
            if (!string.IsNullOrEmpty(id))
            {
                sb.Append("id='").Append(id).Append("' ");
            }
            if (value != null)
            {
                sb.Append("value='").Append(value.ToString()).Append("' ");
            }
            else
            {
                sb.Append("value='1' ");
            }
            if (min != null)
            {
                sb.Append("data-min='").Append(min).Append("' ");
            }
            if (max != null)
            {
                sb.Append("data-max='").Append(max).Append("' ");
            }
            if (step != null)
            {
                sb.Append("data-step='").Append(step).Append("' ");
            }
            if (rule != null)
            {
                sb.Append("data-rule='").Append(rule.ToString()).Append("' ");
            }
            else
            {
                sb.Append("data-rule='quantity' ");
            }
            sb.Append("/>");

            sb.Append("<span class='input-group-addon'>");
            sb.Append("<a href='javascript;;' class='spin-up' data-spin='up'><i class='fa fa-caret-up'></i></a>");
            sb.Append("<a href='javascript:;' class='spin-down' data-spin='down'><i class='fa fa-caret-down'></i></a>");
            sb.Append("</span>");

            tag.InnerHtml = sb.ToString();

            return MvcHtmlString.Create(tag.ToString());


        }
    }

    public enum SpinningRule
    {
        defaults,
        currency,
        quantity,
        percent,
        month,
        day,
        hour,
        minute,
        second,
    }
}