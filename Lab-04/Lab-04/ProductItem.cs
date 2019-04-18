using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class ProductItem
    {
        public Product product { get; set; }
        public int total { get; set; }

        public ProductItem(Product product, int total)
        {
            this.product = product;
            this.total = total;
        }

        public override string ToString()
        {
            return product.name;
        }
    }
}
