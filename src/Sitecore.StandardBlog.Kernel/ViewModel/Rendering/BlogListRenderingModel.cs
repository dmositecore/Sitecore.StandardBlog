using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ItemAdapter;
using Sitecore.Mvc.Extensions;
using Sitecore.Mvc.Presentation;
using Sitecore.StandardBlog.Kernel.Model;
using Sitecore.StandardBlog.Kernel.ViewModel.Partial;

namespace Sitecore.StandardBlog.Kernel.ViewModel.Rendering
{
    public class BlogListRenderingModel : IRenderingModel
    {
        public Sitecore.Data.Items.Item ViewData { get; protected set; }

        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            ViewData = rendering.Item;
        }
    }
}
