using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public void Base (string name, decimal price)
        {
            Name = name;
            Price = price;

        }     
    }
}
