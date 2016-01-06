using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class AuthorViewModel
    {
        public Model.Author ViewData { get; protected set; }

        public AuthorViewModel(Model.Author viewData)
        {
            ViewData = viewData;
        }
    }
}
