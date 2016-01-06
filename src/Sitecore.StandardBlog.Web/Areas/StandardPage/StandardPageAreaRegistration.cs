using System.Web.Mvc;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage
{
    public class StandardPageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StandardPage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StandardPage_action",
                "StandardPageAction/{controller}/{action}/{scItemPath}",
                new { controller ="Page", action = "Index", scItemPath = UrlParameter.Optional }
            );
        }
    }
}