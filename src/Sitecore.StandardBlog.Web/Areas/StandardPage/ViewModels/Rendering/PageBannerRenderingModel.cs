using Sitecore.Mvc.Presentation;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.ViewModels.Rendering
{
    public class PageBannerRenderingModel : IRenderingModel
    {
        public Sitecore.Data.Items.Item ViewData { get; protected set; }

        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            ViewData = rendering.Item;
        }
    }
}
