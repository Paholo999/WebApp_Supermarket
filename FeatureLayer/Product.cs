using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand oBrand { get; set; }
        public Category oCategory { get; set; }
        public decimal Price { get; set; }  
        public int Stock { get; set; }
        public string PathImage { get; set; }
        public string NameImage { get; set; }
        public bool Asset { get; set; }

    }
}
