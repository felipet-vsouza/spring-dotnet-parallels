using System;
using System.Collections.Generic;
using System.Text;

namespace Br.Com.Restaurant.Business.Models
{
    public class Address
    {
        public string building { get; set; }

        public string street { get; set; }

        public string zipcode { get; set; }

        public List<Double> coord { get; set; }
    }
}
