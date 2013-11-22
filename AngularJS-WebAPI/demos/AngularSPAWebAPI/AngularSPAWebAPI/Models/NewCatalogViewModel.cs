﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace AngularSPAWebAPI.Models
{
    public class NewCatalogViewModel
    {
        public string name { get; set; }
        public IEnumerable<CatalogItem> items { get; set; }
    }
}