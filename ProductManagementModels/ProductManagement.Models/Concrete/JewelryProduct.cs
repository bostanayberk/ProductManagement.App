using ProductManagement.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models.Concrete
{
    public class JewelryProduct:BaseEntity
    {
        public string JewelryCarat {  get; set; }

        public JewelryProduct(string name, decimal price, string jewelryCarat) : base(name, price)
        {
            JewelryCarat = jewelryCarat;
        }
    }
}
