using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Br.Com.Restaurant.Business.Models
{
    public class Restaurants
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        public string borough { get; set; }

        public string cuisine { get; set; }

        public string name { get; set; }

        public Address address { get; set; }

        public List<Grade> grades { get; set; }

        public string restaurant_id { get; set; }
    }
}
