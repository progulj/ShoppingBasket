using ShoppingBasktComponent.Models;
using System.Collections.Generic;

namespace ShoppingBasktComponent
{
    class Utils
    {
        public static string MILK_NAME = "Milk";
        public static string BREAD_NAME = "Bread";
        public static string BUTTER_NAME = "Butter";

        public static int MILK_CODE = 1;
        public static int BREAD_CODE = 2;
        public static int BUTTER_CODE = 3;

        public static double MILK_PRICE = 1.15;
        public static double BREAD_PRICE = 1.00;
        public static double BUTTER_PRICE = 0.80;



        public static IList<Discount> GetAllDiscounts(List<Product> products)
        {
            IList<Discount> discounts = new List<Discount>();

            discounts.Add(new OtherProductDiscountedByPercentage(products));
            discounts.Add(new FreeProductDiscount(products));

            return discounts;
        }
    }
}
