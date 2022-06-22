using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages;

namespace Fiducolmena.Filters
{
    public enum DeviceType { Mobile, Desktop }

    public class DeviceTypeRedirect : ActionFilterAttribute
    {
        public string RedirectController { get; set; }

        public string RedirectAction { get; set; }

        public DeviceType RedirectOnDevice { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            using (var db = new SARLAFTFIDUCOLMENAEntities())
            {

            }
            if (filterContext.HttpContext.GetOverriddenBrowser().IsMobileDevice == (this.RedirectOnDevice == DeviceType.Mobile))
            {
                this.RedirectToRoute(filterContext, new { controller = this.RedirectController, action = this.RedirectAction });
            }
        }

        private void RedirectToRoute(ActionExecutingContext context, object routeValues)
        {
            var rc = new RequestContext(context.HttpContext, context.RouteData);
            var virtualPathData = RouteTable.Routes.GetVirtualPath(rc, new RouteValueDictionary(routeValues));
            if (virtualPathData != null)
            {
                string url = virtualPathData.VirtualPath;
                context.HttpContext.Response.Redirect(url, true);
            }
        }
    }
}