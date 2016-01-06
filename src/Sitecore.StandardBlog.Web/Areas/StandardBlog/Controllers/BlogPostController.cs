using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.ItemAdapter;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using Sitecore.StandardBlog.Kernel.Model;
using Sitecore.StandardBlog.Kernel.ViewModel;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;

namespace Sitecore.StandardBlog.Web.Areas.StandardBlog.Controllers
{
    public class BlogPostController : StandardController
    {
        public new ActionResult Index(string scItemPath)
        {
            var contextId = new Data.ID(scItemPath);
            var contextItem = Sitecore.Context.Database.GetItem(contextId);

            if (contextItem == null)
            {
                return HttpNotFound();
            }
            SetPageContextItem(contextItem);


            var parentBlogItem = contextItem.Parent.Parent;


            var blogPostViewData = StandardItemAdapter<BlogPost>.CreateExtendedModelInstance(contextItem, 1);
            var blogViewData = StandardItemAdapter<Blog>.CreateModelInstance(parentBlogItem, 0);

            var viewModel = new BlogPostViewModel(blogPostViewData);
            viewModel.BlogViewModel = new BlogViewModel(blogViewData);

            ViewData.Model = viewModel;

            return GetDefaultAction();
        }

        public PartialViewResult List(string scItemPath, BlogPostListViewModel viewModel)
        {
            ViewData.Model = viewModel;
            return PartialView();
        }


        // GET: StandardBlog/BlogPost
        public PartialViewResult ListItem(string scItemPath, BlogPostListItemViewModel viewModel)
        {
            ViewData.Model = viewModel;
            return PartialView();
        }
    }
}