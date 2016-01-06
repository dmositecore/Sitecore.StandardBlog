using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Mvc.Presentation;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Layout
{
    public class AuthorLayoutViewModel : IRenderingModel
    {
        public AuthorLayoutViewModel()
        {
        }

        public AuthorViewModel ViewModel { get; protected set; }

        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            AuthorViewModel viewModel = (AuthorViewModel)PageContext.Current.HtmlHelper.ViewContext.ViewData.Model;

            if (viewModel == null)
            {
                throw new Exception("Invalid ViewData AuthorViewModel");
            }

            ViewModel = viewModel;
        }


    }
}
