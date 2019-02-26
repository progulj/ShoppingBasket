using System.Collections.Generic;

namespace ShoppingBasktComponent.Models
{
    class OtherProductDiscountedByPercentage : Discount
    {

        public OtherProductDiscountedByPercentage(List<Product> products)
        {
            this.products = products;
        }

        public override double ApplayDiscount()
        {
            double discount = 0.0;

            if (products.Exists(x => x.ProductType == Utils.BREAD_CODE) && products.Exists(x => x.ProductType == Utils.BUTTER_CODE))
            {
                discount += GetOtherProductDiscountedByPercentage(Utils.BREAD_CODE, Utils.BREAD_NAME, 0.5, products.Find(x => x.ProductType == Utils.BREAD_CODE).NumberOfItems, products.Find(x => x.ProductType == Utils.BUTTER_CODE).NumberOfItems, products.Find(x => x.ProductType == Utils.BREAD_CODE).ItemPrice);

            }
            return discount;
        }

        public double GetOtherProductDiscountedByPercentage(int type, string name, double percentage, int numberOfItems, int numberOfOtherItems, double itemPrice)
        {
            double discountedPrice = 0.0;
            double fullPrice = 0.0;

            double discounted = numberOfOtherItems * percentage;
            int discountedCounter = (int)discounted;

            for (int i = 1; i <= numberOfItems - discountedCounter; i++)
            {

                discountedPrice += itemPrice;
                fullPrice += itemPrice;


            }
            for (int i = 1; i <= discountedCounter; i++)
            {

                discountedPrice += itemPrice / 2;
                fullPrice += itemPrice;

            }
            if (discountedCounter > 0)
            {
                DiscountedItems = $"Number of discounted {name} is {discountedCounter}";
            }
            return fullPrice - discountedPrice;
        }
    }
}
