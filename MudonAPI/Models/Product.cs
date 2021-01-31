using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudonAPI.Models
{
    public abstract class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string ImageURI { get; set; }
        public string Country { get; set; }
        public DateTime CompleteDate { get; set; }
        public bool Completed { get; set; }
        public DateTime BuyDate { get; set; }
        public bool Buy { get; set; }
        public double Price { get; set; }
    }
}
