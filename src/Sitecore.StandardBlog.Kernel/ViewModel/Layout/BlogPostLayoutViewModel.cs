using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ItemAdapter;
using Sitecore.Mvc.Presentation;
using Sitecore.StandardBlog.Kernel.Model;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Layout
{
    public class BlogPostLayoutViewModel : IRenderingModel
    {
        public BlogPostLayoutViewModel()
        {
        }

        public BlogPostViewModel BlogPostViewModel { get; protected set; }
        
        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            var contextViewData = PageContext.Current.HtmlHelper.ViewContext.ViewData;
            BlogPostViewModel viewModel = (BlogPostViewModel)contextViewData.Model;

            if (viewModel == null)
            {
                throw new Exception("Invalid ViewData BlogPostViewModel");
            }

            BlogPostViewModel = viewModel;
        }

    }
}
