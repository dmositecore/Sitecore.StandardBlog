using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogPostListItemViewModel
    {
        public Model.BlogPost ViewData { get; protected set; }

        public BlogPostListItemViewModel(Model.BlogPost model)
        {
            ViewData = model;
        }
    }
}
