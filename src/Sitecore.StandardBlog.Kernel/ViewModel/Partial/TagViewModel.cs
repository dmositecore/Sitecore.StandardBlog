using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Partial
{
    public class TagViewModel
    {
        public Model.Tag ViewData { get; protected set; }

        public TagViewModel(Model.Tag viewData)
        {
            ViewData = viewData;
        }
    }
}
