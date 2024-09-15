using ProductManagement.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProductManagement.Models.Concrete
{
    public class CosmeticsProduct : BaseEntity
    {
        public string Type { get; set; }
        public CosmeticsProduct(string name, decimal price,string  type) : base(name, price)
        {
           Type = type;
        }

       
     
    }
  
}
