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
    public class BlogLayoutViewModel : IRenderingModel
    {
        public BlogLayoutViewModel()
        {
        }

        public BlogViewModel BlogViewModel { get; protected set; }
        
        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            BlogViewModel viewModel = (BlogViewModel)PageContext.Current.HtmlHelper.ViewContext.ViewData.Model;

            if (viewModel == null)
            {
                throw new Exception("Invalid ViewData BlogViewModel");
            }

            BlogViewModel = viewModel;
        }


    }
}
