using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.ItemAdapter;
using Sitecore.StandardBlog.Web.Areas.StandardPage.ViewModels.Partial;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.Controllers
{
    public class PageController : StandardController
    {
        // GET: StandardPage/Page
        public ActionResult Index()
        {
            return GetDefaultAction();
        }

        public PartialViewResult PageBanner(string scItemPath)
        {
            var contextId = new Data.ID(scItemPath);
            var contextItem = Sitecore.Context.Database.GetItem(contextId);

            var viewData = StandardItemAdapter<Models.StandardPage>.CreateExtendedModelInstance(contextItem, 0);
            ViewData.Model = new PageBannerViewModel(viewData);

            return PartialView();
        }
    }
}