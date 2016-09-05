using BootstrapHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(User model)
        {
            model.Name = "Jim";
            return View(model);
        }

        public JsonResult GetDept()
        {
            var lstRes = new List<Dept>();
            lstRes.Add(new Dept() { Id = "aa", Name = "生产部" });
            lstRes.Add(new Dept() { Id = "bb", Name = "后勤部" });
            lstRes.Add(new Dept() { Id = "cc", Name = "供应部" });
            lstRes.Add(new Dept() { Id = "dd", Name = "开发部" });
            lstRes.Add(new Dept() { Id = "ee", Name = "事业部" });

            return Json(lstRes, JsonRequestBehavior.AllowGet);
        }
    }

    public class Dept
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}