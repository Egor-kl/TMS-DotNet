using System;
using System.Collections.Generic;

namespace EnternetMagazine
{
    internal class ShoppingCart : Product
    {
        internal static List<string> ShoppingCartUser = new List<string>();
        public virtual void ShoppingMethod(List<string> ShoppingCartUser)
        {
            Console.WriteLine("Что вы хотите купить из этого списка?");
            for (var i = 0; i < ProductName.Count; i++)
            {
                Console.WriteLine($"Наименование товара, цена: {ProductName[i]}, {ProductPrice[i]}");
            }
            string UserInput = Console.ReadLine();
            ShoppingCartUser.Add(UserInput);

        }
         
    }
    class Discount : ShoppingCart
    {
        public override void ShoppingMethod(List<string> ShoppingCartUser)
        {
            if (ShoppingCartUser.Count > 5)
            {
                Console.WriteLine("Вы хотите купить больше 5 товаров, вам предоставляется скидка в 10% на вашу корзину !!");
                for (var i = 0; i<ShoppingCartUser.Count;i++)
                {
                    Console.WriteLine(ShoppingCartUser[i]);
                }
            }
            else
            {
                int sum = 0;
                foreach (int value in ProductPrice)
                {
                    sum += value;
                }
                Console.WriteLine($"С вас {sum}");
            }
        }
        
    }      
}

