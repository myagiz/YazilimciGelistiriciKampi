using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceEntities.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public bool isProductinStock { get; set; }
    }
}
