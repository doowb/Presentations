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
        public List<object> Get(string id)
        {
            var results = new List<object>();
            results.Add(id);
            return results;
        }
    }
}
