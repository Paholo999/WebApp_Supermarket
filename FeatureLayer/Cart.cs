using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer
{
    public class Cart
    {
        public int Id { get; set; }
        public Customer oCustomer { get; set; }
        public Product oProduct { get; set; }
        public int Amount { get; set; }
    }
}
