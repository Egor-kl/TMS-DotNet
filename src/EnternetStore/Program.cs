using System;
using System.Collections.Generic;

namespace EnternetMagazine
{
    class Program
    {
        public static void Main(string[] args)
        {
            var productName = new List<string>();
            var productPrice = new List<double>();
            var productWeight = new List<double>();
            var shoppingCartUser = new List<string>();

            var shopCart = new ShoppingCart();
            var disc = new Discount();

            var product = new Product();
            product.ProductName = productName;
            product.ProductPrice = productPrice;
            product.ProductWeight = productWeight;

            Console.WriteLine("Привет, если что-то хочешь добавить в магазин, то нажми 'S'");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "s")
            {
                // TODO: rename method
                product.SomeMethod(productName, productPrice, productWeight);
            }

            shopCart.ShoppingMethod(shoppingCartUser);
            disc.ShoppingMethod(shoppingCartUser);
        }
    }
}
