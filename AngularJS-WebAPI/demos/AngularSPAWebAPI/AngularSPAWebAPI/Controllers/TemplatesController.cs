using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularSPAWebAPI.Controllers
{
    public class TemplatesController : Controller
    {
        public ActionResult Index(string template)
        {
            return View(template);
        }

    }
}
