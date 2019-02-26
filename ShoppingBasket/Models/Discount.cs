using System;
using System.Collections.Generic;

namespace ShoppingBasktComponent.Models
{
    class Discount : IDiscount
    {
        public List<Product> products;
        public string DiscountedItems;


        public virtual double ApplayDiscount()
        {
            return 0.0;
        }

    }
}
