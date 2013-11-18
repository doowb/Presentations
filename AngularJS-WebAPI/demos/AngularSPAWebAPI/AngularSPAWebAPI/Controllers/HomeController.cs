using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularSPAWebAPI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string path)
        {
            return View();
        }
    }
}
