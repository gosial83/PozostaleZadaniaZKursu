using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.Models
{
    public class ProductSaleSummary
    {
        public Product Product { get; set; }
        public int QuantitySold { get; set; }

        public ProductSaleSummary(Product product, int quantitySold)
        {
            Product = product;
            QuantitySold = quantitySold;
        }
    }
}
