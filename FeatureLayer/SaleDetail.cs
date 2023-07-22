using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public int IdSale { get; set; }
        public Product oProduct { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        public string IdTransaction { get; set; }

    }
}
