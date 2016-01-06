using System;
using System.Collections.Generic;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.ViewModels.Partial
{
    public class BreadcrumbViewModel
    {
        public BreadcrumbViewModel()
        {
            ViewData = new List<Tuple<string, string>>();
        }
        public List<Tuple<string, string>> ViewData { get; set; }
    }
}