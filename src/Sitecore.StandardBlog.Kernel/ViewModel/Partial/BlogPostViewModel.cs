using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogPostViewModel
    {
        public Model.BlogPost ViewData { get; protected set; }

        public BlogViewModel BlogViewModel { get; set; }

        public BlogPostViewModel(Model.BlogPost model)
        {
            ViewData = model;
        }

    }
}
