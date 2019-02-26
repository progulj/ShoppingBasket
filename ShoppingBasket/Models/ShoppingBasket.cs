using System;
using System.Collections.Generic;

namespace ShoppingBasktComponent.Models
{
    class ShoppingBasket
    {
        private int Id { get; set; }
        private double FullPrice { get; set; }
        private double DiscountedPrice { get; set; }
        private double Discount { get; set; }
        private List<Product> Products { get; set; }
        private List<string> ProductsOnDiscount { get; set; }
        private ILogger logger;

        public ShoppingBasket(ILogger logger)
        {
            this.logger = logger;
            FullPrice = 0.0;
            DiscountedPrice = 0.0;
            Discount = 0.0;
            Products = new List<Product>();
            ProductsOnDiscount = new List<string>();
        }


        public void AddToShoppingBasket(Product product)
        {
            Products.Add(product);
        }


        public void GetFullPrice()
        {
            FullPrice = 0.0;

            foreach (Product product in Products)
            {
                FullPrice += product.ItemPrice * product.NumberOfItems;
            }
        }

        public void GetDiscountedPrice()
        {
            DiscountedPrice = 0.0;
            GetDiscount();

            DiscountedPrice = FullPrice - Discount;

        }

        public void GetDiscount()
        {
            IList<Discount> discounts = Utils.GetAllDiscounts(Products);
            foreach (Discount discount in discounts)
            {
                Discount += discount.ApplayDiscount();
                if (!String.IsNullOrEmpty(discount.DiscountedItems))
                {
                    ProductsOnDiscount.Add(discount.DiscountedItems);
                }
            }
        }


        public void ConfirmShoppingBasket()
        {
            GetFullPrice();
            GetDiscountedPrice();
            SaveBasket();
        }


        private void SaveBasket()
        {
            logger.Write("SHOPPING BASKET");
            logger.Write($"Original Price is {FullPrice}");
            logger.Write($"Actual Price is {DiscountedPrice}");
            logger.Write($"Total Discount is {Discount}");
            foreach (string productOnDiscount in ProductsOnDiscount)
            {
                logger.Write(productOnDiscount);
            }
            logger.Write("#########################################\n\n");
        }

    }
}
