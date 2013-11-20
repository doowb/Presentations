using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AngularSPAWebAPI.Extensions;

namespace AngularSPAWebAPI.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            ViewBag.ApplicationPath = String.Format("{0}://{1}{2}",
                System.Web.HttpContext.Current.Request.Url.Scheme,
                System.Web.HttpContext.Current.Request.Url.Authority,
                HttpRuntime.AppDomainAppVirtualPath);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            // log exception here
            filterContext.ExceptionHandled = true;
            View("Error").ExecuteResult(ControllerContext);
        }

        protected override IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, AsyncCallback callback, object state)
        {
            requestContext.HttpContext.Response.Cache.SetMaxAge(new TimeSpan(0));
            return base.BeginExecute(requestContext, callback, state);
        }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JSonNetResults.JsonNetResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }
    }
}
