using lodash.Models;
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
        public IList<IModel> Get(string id)
        {
            var results = new List<IModel>();

            switch (id.ToLower())
            {
                case "food":
                    results = Food.GetAll();
                    break;
                default:
                    break;
            };

            return results;
        }
    }
}
