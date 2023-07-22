using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdCustomer { get; set;}
        public int TotalProduct { get; set; }
        public decimal TotalAmount { get; set; }
        public string Contact { get; set; }
        public string IdDistrict { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IdTransaction { get; set; }
        public string DateText { get; set; }
        public List<SaleDetail> oSaleDetail { get; set; }

    }
}
