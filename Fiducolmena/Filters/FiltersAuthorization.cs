using Fiducolmena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Routing;

namespace Fiducolmena.Filters
{
    public class FiltersAuthorization : IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var action = filterContext.ActionDescriptor.ActionName;

            var requestNumber = filterContext.HttpContext.Request.Params.GetValues("RequestNumber");
            if (action == "Index" && requestNumber == null) { 
                RedirectToRoute(filterContext, "ErrorRequestNumber");
                return;
            }
            else
            {
                if (requestNumber != null)
                {
                    using (var db = new SARLAFTFIDUCOLMENAEntities())
                    {

                        var request = requestNumber[0];
                        var rqn = db.Persona_val.FirstOrDefault(x => x.REQUEST_NUMBER == request);
                        if (rqn == null)
                        {
                            RedirectToRoute(filterContext, "ErrorRequestNumber");
                        }
                        else
                        {
                            var bRn = db.BiometricValidationState.FirstOrDefault(x => x.RequestNumber == request);
                            if (bRn == null || DateTime.UtcNow > bRn.DateExpiry)
                            {
                                RedirectToRoute(filterContext, "Errorlink");
                                return;
                            }
                            if(bRn.LinkAccess != null)
                            {
                                RedirectToRoute(filterContext, "ErrorLinkAccess");
                            }
                        }
                    }
                }
            }

        }


        private void RedirectToRoute(AuthorizationContext filterContext, string action)
        {
            var rc = new RequestContext(filterContext.HttpContext, filterContext.RouteData);
            var virtualPathData = RouteTable.Routes.GetVirtualPath(rc, new RouteValueDictionary
                        {
                            {"action", action},
                            {"controller", "Home"}

                        });
            if (virtualPathData != null)
            {
                string url = virtualPathData.VirtualPath;
                filterContext.Result = new RedirectResult(url);
            }
        }
    }

}