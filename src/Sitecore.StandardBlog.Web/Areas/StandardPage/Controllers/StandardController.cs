using System;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Configuration;
using Sitecore.Mvc.Extensions;
using Sitecore.Mvc.Presentation;
using Sitecore.Web;

namespace Sitecore.StandardBlog.Web.Areas.StandardPage.Controllers
{
    public abstract class StandardController : Controller
    {

        protected virtual ActionResult GetDefaultAction()
        {
            IView pageView = PageContext.Current.PageView;
            if (pageView == null)
                return this.RedirectToNotFound();
            return (ActionResult)this.View(pageView);
        }

        protected virtual ActionResult RedirectToNotFound()
        {
            PageContext current = PageContext.Current;
            string localPath = current.RequestContext.HttpContext.Request.Url.LocalPath;
            string str = ObjectExtensions.ValueOrDefault<Route, string>(current.RequestContext.RouteData.Route as Route, (Func<Route, string>)(route => route.Url));
            if (str != null)
                localPath += Sitecore.StringExtensions.StringExtensions.FormatWith(" (route: {0})", (object)str);
            string userName = Context.GetUserName();
            string siteName = Context.GetSiteName();
            return (ActionResult)this.Redirect(WebUtil.AddQueryString(Settings.ItemNotFoundUrl, "item", localPath, "user", userName, "site", siteName));
        }

    }
}