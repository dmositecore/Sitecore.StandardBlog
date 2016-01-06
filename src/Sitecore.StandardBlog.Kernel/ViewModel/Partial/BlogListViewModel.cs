using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogListViewModel
    {
        public IEnumerable<BlogListItemViewModel> ViewModel { get; protected set; }

        public BlogListViewModel(IEnumerable<BlogListItemViewModel> viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
