using System;
using System.Collections.Generic;
using System.Text;

namespace Br.Com.Restaurant.Business.DTOs
{
    public class DTORestaurant
    {
        public string id { get; set; }

        public string borough { get; set; }

        public string cuisine { get; set; }

        public string name { get; set; }

        public DTOAddress address { get; set; }

        public List<DTOGrade> grades { get; set; }
    }
}
