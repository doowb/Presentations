using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lodash.Controllers
{
    public class DataController : ApiController
    {
        public object Get(string id)
        {
            var results = new List<object>();
            var i = 1;
            results.Add(id + "_" + i++);
            results.Add(id + "_" + i++);
            results.Add(id + "_" + i++);
            results.Add(id + "_" + i++);
            results.Add(id + "_" + i++);
            return results;
        }
    }
}
