﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models
{
    public class Cars
    {
        public string theCarBrand { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int mileage { get; set; }
    }
}