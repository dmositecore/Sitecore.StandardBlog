using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.ItemAdapter;
using Sitecore.StandardBlog.Kernel.Model;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;

namespace Sitecore.StandardBlog.Web.Areas.StandardBlog.Controllers
{
    public class TagController : StandardController
    {
        // GET: StandardBlog/Tag
        public ActionResult Index(string scItemPath)
        {
            var contextId = new Data.ID(scItemPath);
            var contextItem = Sitecore.Context.Database.GetItem(contextId);

            if (contextItem == null)
            {
                return HttpNotFound();
            }
            SetPageContextItem(contextItem);

            Tag viewData = StandardItemAdapter<Tag>.CreateExtendedModelInstance(contextItem, 0);

            ViewData.Model = new TagViewModel(viewData);

            return GetDefaultAction();
        }
    }
}