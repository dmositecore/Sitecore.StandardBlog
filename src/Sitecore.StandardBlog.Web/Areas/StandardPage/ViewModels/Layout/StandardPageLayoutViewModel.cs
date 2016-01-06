using System.Web;
using Sitecore.ItemAdapter;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.ViewModels.Layout
{
    public class StandardPageLayoutViewModel : IRenderingModel
    {
        public Models.StandardPage ViewData { get; protected set; }

        public void Initialize(Mvc.Presentation.Rendering rendering)
        {
            ViewData = StandardItemAdapter<Models.StandardPage>.CreateExtendedModelInstance(rendering.Item, 1);

            PageContext.Current.HtmlHelper.ViewData.Model = this;
        }
    }
}