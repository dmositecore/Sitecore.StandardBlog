using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogViewModel
    {
        public Model.Blog ViewData { get; protected set; }
        
        public BlogPostListViewModel BlogPostListViewModel { get; set; }
        public BlogViewModel(Model.Blog model)
        {
            ViewData = model;
        }
    }
}
