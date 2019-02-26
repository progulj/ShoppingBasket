using ShoppingBasktComponent.Models;
using System;

namespace ShoppingBasktComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START: \n\n");

            //Example 1 Start
            ShoppingBasket basket1 = new ShoppingBasket(new Logger());

            basket1.AddToShoppingBasket(new Product(Utils.MILK_NAME, Utils.MILK_PRICE, Utils.MILK_CODE, 1));
            basket1.AddToShoppingBasket(new Product(Utils.BREAD_NAME, Utils.BREAD_PRICE, Utils.BREAD_CODE, 1));
            basket1.AddToShoppingBasket(new Product(Utils.BUTTER_NAME, Utils.BUTTER_PRICE, Utils.BUTTER_CODE, 1));

            basket1.ConfirmShoppingBasket();

            //Example 1 End

            //Example 2 Start
            ShoppingBasket basket2 = new ShoppingBasket(new Logger());

            basket2.AddToShoppingBasket(new Product(Utils.BREAD_NAME, Utils.BREAD_PRICE, Utils.BREAD_CODE, 2));
            basket2.AddToShoppingBasket(new Product(Utils.BUTTER_NAME, Utils.BUTTER_PRICE, Utils.BUTTER_CODE, 2));

            basket2.ConfirmShoppingBasket();
            //Example 2 End

            //Example 3 Start
            ShoppingBasket basket3 = new ShoppingBasket(new Logger());

            basket3.AddToShoppingBasket(new Product(Utils.MILK_NAME, Utils.MILK_PRICE, Utils.MILK_CODE, 4));

            basket3.ConfirmShoppingBasket();
            //Example 3 End

            //Example 4 Start
            ShoppingBasket basket4 = new ShoppingBasket(new Logger());

            basket4.AddToShoppingBasket(new Product(Utils.MILK_NAME, Utils.MILK_PRICE, Utils.MILK_CODE, 8));
            basket4.AddToShoppingBasket(new Product(Utils.BREAD_NAME, Utils.BREAD_PRICE, Utils.BREAD_CODE, 1));
            basket4.AddToShoppingBasket(new Product(Utils.BUTTER_NAME, Utils.BUTTER_PRICE, Utils.BUTTER_CODE, 2));

            basket4.ConfirmShoppingBasket();

            //Example 4 End
            Console.WriteLine("END: \n\n");
        }
    }
}
