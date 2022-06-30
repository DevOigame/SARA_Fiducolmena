using Fiducolmena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Routing;
using System.Data.Entity;

namespace Fiducolmena.Filters
{
    public class FilterLinkUsed : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var requestNumber = filterContext.HttpContext.Request.Params.GetValues("RequestNumber");
            if (requestNumber != null)
            {
                using (var db = new SARLAFTFIDUCOLMENAEntities())
                {
                    var request = requestNumber[0];
                    var rqn = db.BiometricValidationState.FirstOrDefault(x => x.RequestNumber == request);
                    if (rqn != null)
                    {
                        rqn.LinkAccess = DateTime.UtcNow;
                        db.Entry(rqn).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }

        }


    }

}