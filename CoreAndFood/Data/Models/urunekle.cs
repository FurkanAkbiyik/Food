﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class urunekle
    {
        public string Name { get; set; }
      //  public string Description { get; set; }

        public double price { get; set; }
        public IFormFile ImageURL { get; set; }

        public int Stock { get; set; }
        public int CategoryID { get; set; }
    }
}