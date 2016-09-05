using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapExtensions
{
    public abstract class BootstrapWebViewPage<TModel> : System.Web.Mvc.WebViewPage<TModel>
    {
        //在cshtml页面里面使用的变量
        public BootstrapHelper<TModel> Bootstrap { get; set; }

        /// <summary>
        /// 初始化Bootstrap对象
        /// </summary>
        public override void InitHelpers()
        {
            base.InitHelpers();
            Bootstrap = new BootstrapHelper<TModel>(ViewContext, this);
        }

        public override void Execute()
        {
            //throw new NotImplementedException();
        }
    }
}