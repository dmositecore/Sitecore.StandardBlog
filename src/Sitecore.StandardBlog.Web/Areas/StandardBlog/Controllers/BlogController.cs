using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.ItemAdapter;
using Sitecore.Mvc.Controllers;
using Sitecore.StandardBlog.Kernel.Model;
using Sitecore.StandardBlog.Kernel.ViewModel;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;
using PageContext = Sitecore.Mvc.Presentation.PageContext;
using System.Web.Routing;
using Sitecore.Configuration;
using Sitecore.Mvc.Extensions;
using Sitecore.Web;

namespace Sitecore.StandardBlog.Web.Areas.StandardBlog.Controllers
{
    public class BlogController : StandardController
    {
        public readonly int LoadBlogPostFolders = 3;
        // GET: StandardBlog/Blog
        public ActionResult Index(string scItemPath)
        {
            var contextId = new Data.ID(scItemPath);
            var contextItem = Sitecore.Context.Database.GetItem(contextId);

            if (contextItem == null)
            {
                return HttpNotFound();
            }
            SetPageContextItem(contextItem);

            GetViewModel(contextItem);
            GetBlogPostListViewModel();
            return GetDefaultAction();
        }

        public ActionResult List(string scItemPath)
        {

            var contextId = new Data.ID(scItemPath);
            var contextItem = Sitecore.Context.Database.GetItem(contextId);

            IEnumerable<Blog> viewData = StandardItemAdapter<Blog>.GetEnumerator(contextItem.Children.ToArray(), 0);

            IEnumerable<BlogListItemViewModel> innerViewModel = viewData.Select(blog => new BlogListItemViewModel(blog));

            ViewData.Model = new BlogListViewModel(innerViewModel);

            return PartialView();
        }


        private void GetBlogPostListViewModel()
        {
            BlogViewModel blogViewModel = (BlogViewModel)ViewData.Model;
            var blogFolders = blogViewModel.ViewData.Children.Cast<BlogPostFolder>();

            var showFolders = blogFolders.Take(LoadBlogPostFolders).Select(folder => Sitecore.Context.Database.GetItem(new Data.ID(folder.Id))).ToArray();

            var getFolders = showFolders.Select(folder => StandardItemAdapter<BlogPostFolder>.CreateExtendedModelInstance(folder, 1));

            List<BlogPostListItemViewModel> blogPostList = new List<BlogPostListItemViewModel>();
            foreach (BlogPostFolder folder in getFolders)
            {
                List<BlogPost> posts = folder.Children.Cast<BlogPost>().ToList();

                foreach (BlogPost post in posts)
                {
                    blogPostList.Add(new BlogPostListItemViewModel(post));
                }
            }
            var viewModel = new BlogPostListViewModel(blogPostList);

            blogViewModel.BlogPostListViewModel = new BlogPostListViewModel(blogPostList);
        }

        private void GetViewModel(Item contextItem)
        {
            var blogViewData = StandardItemAdapter<Blog>.CreateExtendedModelInstance(contextItem, 1);

            var blogViewModel = new BlogViewModel(blogViewData);
            ViewData.Model = blogViewModel;
        }

        
    }
}