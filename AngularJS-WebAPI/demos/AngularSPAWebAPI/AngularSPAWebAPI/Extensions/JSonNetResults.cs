using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace AngularSPAWebAPI.Extensions
{
    public class JSonNetResults
    {
        /// <summary>
        /// This class is here to allow us to use the NewtonSoft JSON.Net Serializer rather than the native JSONSerializer that
        /// MVC uses by default. 
        /// </summary>
        /// <remarks>Code below taken from Ricky Wan's post.</remarks>
        /// <seealso cref="http://wingkaiwan.com/tag/json-net/"/>
        /// <seealso cref="http://json.codeplex.com/"/>
        public class JsonNetResult : JsonResult
        {
            public JsonNetResult()
            {
                Settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Error
                };
            }

            public JsonSerializerSettings Settings { get; private set; }

            public override void ExecuteResult(ControllerContext context)
            {
                if (context == null)
                    throw new ArgumentNullException("context");
                if (this.JsonRequestBehavior == JsonRequestBehavior.DenyGet &&
                    string.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("JSON GET is not allowed");

                HttpResponseBase response = context.HttpContext.Response;
                response.ContentType = string.IsNullOrEmpty(this.ContentType) ? "application/json" : this.ContentType;

                if (this.ContentEncoding != null)
                    response.ContentEncoding = this.ContentEncoding;
                if (this.Data == null)
                    return;

                var scriptSerializer = JsonSerializer.Create(this.Settings);
                using (var sw = new StringWriter())
                {
                    scriptSerializer.Serialize(sw, this.Data);
                    response.Write(sw.ToString());
                }
            }
        }
    }
}