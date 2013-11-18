using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AngularSPAWebAPI.Controllers.Api
{
    [System.Web.Http.Authorize]
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class BaseApiController : ApiController
    {
        public BaseApiController() { }
    }
}
