using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.StandardBlog.Kernel.Model;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class BlogListItemViewModel
    {
        public Blog ViewData { get; protected set; }
        public BlogListItemViewModel(Blog viewData)
        {
            ViewData = viewData;
        }
    }
}
