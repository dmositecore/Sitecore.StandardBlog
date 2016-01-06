using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.StandardBlog.Web.Areas.StandardBlog.Controllers
{
    public class TestController : StandardController
    {
        // GET: StandardBlog/Test
        public ActionResult Index()
        {
            return Json(new {@test = true, @now = DateTime.UtcNow.ToString("u")}, JsonRequestBehavior.AllowGet);
        }
    }
}