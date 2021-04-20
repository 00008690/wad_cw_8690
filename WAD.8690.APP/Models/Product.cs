using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD._8690.APP.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SoldPrice { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Buyer { get; set; }
    }
}
