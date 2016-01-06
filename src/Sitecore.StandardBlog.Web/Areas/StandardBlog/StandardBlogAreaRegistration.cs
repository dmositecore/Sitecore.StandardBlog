using System.Web.Mvc;
using System.Web.Routing;

namespace Sitecore.StandardBlog.Web.Areas.StandardBlog
{
    public class StandardBlogAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StandardBlog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            var route = context.MapRoute(
                "StandardBlog_default",
                "StandardBlog/{controller}/{action}/{scItemPath}",
                new { controller = "Blog", action = "Index", scItemPath = UrlParameter.Optional }
            );
            InitializeSitecoreAreaRoute(route);
        }

        private static void InitializeSitecoreAreaRoute(Route route)
        {
            IRouteHandler routeHandler = route.RouteHandler;
            if (routeHandler != null && !(routeHandler is StopRoutingHandler))
            {
                route.RouteHandler = new Sitecore.Mvc.Routing.RouteHandlerWrapper(routeHandler);
            }
        }

    }
}