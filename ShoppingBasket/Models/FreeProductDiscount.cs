using System.Collections.Generic;

namespace ShoppingBasktComponent.Models
{
    class FreeProductDiscount : Discount
    {

        public FreeProductDiscount(List<Product> products)
        {
            this.products = products;
        }

        public override double ApplayDiscount()
        {
            double discount = 0.0;

            if (products.Exists(x => x.ProductType == Utils.MILK_CODE))
            {
                discount += GetFreeProductDiscount(Utils.MILK_CODE, Utils.MILK_NAME, 4, products.Find(x => x.ProductType == Utils.MILK_CODE).NumberOfItems, products.Find(x => x.ProductType == Utils.MILK_CODE).ItemPrice);

            }
            return discount;
        }

        private double GetFreeProductDiscount(int type, string name, int freeProduct, int numberOfItems, double itemPrice)
        {
            double discountedPrice = 0.0;
            double fullPrice = 0.0;

            int freeProductCounter = 0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                fullPrice += itemPrice;
                if (i % freeProduct != 0)
                {
                    discountedPrice += itemPrice;
                }
                else
                {
                    freeProductCounter++;
                }
            }
            if (freeProductCounter > 0)
            {
                DiscountedItems = $"Number of discounted {name} is {freeProductCounter}";
            }

            return fullPrice - discountedPrice;
        }
    }
}
