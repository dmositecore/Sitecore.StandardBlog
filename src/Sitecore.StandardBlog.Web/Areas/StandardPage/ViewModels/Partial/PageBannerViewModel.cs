using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.StandardBlog.Web.Areas.StandardPage.Models;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.ViewModels.Partial
{
   
    public class PageBannerViewModel
    {
        public PageBannerViewModel(Models.StandardPage viewData)
        {
            ViewData = viewData;
        }
        public Models.StandardPage ViewData { get; protected set; }
    }
}