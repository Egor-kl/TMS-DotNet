using System;
using System.Collections.Generic;

namespace EnternetMagazine
{

    class Program
    {
        public static void Main(string[] args)
        {
            List<string> ProductName = new List<string>();
            List<double> ProductPrice = new List<double>();
            List<double> ProductWeight = new List<double>();
            List<string> ShoppingCartUser = new List<string>();
            var Prod = new Product();
            var ShopCart = new ShoppingCart();
            var Disc = new Discount();
            Product.ProductName = ProductName;
            Product.ProductPrice = ProductPrice;
            Product.ProductWeight = ProductWeight;

            Console.WriteLine("Привет, если что-то хочешь добавить в магазин, то нажми 'S' ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "s")
            {
                Prod.SomeMethod(ProductName, ProductPrice, ProductWeight);
            }
            ShopCart.ShoppingMethod(ShoppingCartUser);
            Disc.ShoppingMethod(ShoppingCartUser);
        }
        
        
        
        
    }
}
