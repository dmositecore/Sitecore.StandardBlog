using System.Collections.Generic;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogPostListViewModel 
    {
        public IEnumerable<BlogPostListItemViewModel>  ViewModel { get; protected set; }
        
        public BlogPostListViewModel(IEnumerable<BlogPostListItemViewModel> viewModel)
        {
            ViewModel = viewModel;
        }

    }
}
