using System;
using System.Collections.Generic;

namespace EnternetMagazine
{
    class Product
    {
        internal List<string> ProductName = new List<string>();
        internal List<double> ProductPrice = new List<double>();
        internal List<double> ProductWeight = new List<double>();

        public void SomeMethod(List<string> productName, List<double> productPrice, List<double> productWeight)
        {
            Console.WriteLine("Если хотите что-то добавить в ассортимент, то нажмите Y, если просмотреть что есть в ассортименте нажмите L");
            string UserInput = Console.ReadLine().ToLower();
            try
            {
                if (UserInput == "y")
                {
                    Console.WriteLine("Введите наименование товара: ");
                    string UserInputName = Console.ReadLine();
                    Console.WriteLine("Введите цену товара: ");
                    double UserInputPrice = Convert.ToDouble(Console.ReadLine());
                    ProductName.Add(UserInputName);
                    ProductPrice.Add(UserInputPrice);
                    Console.WriteLine("Если товар продаётся поштучно введите 1, если на развес, то введите 0, а затем его вес");
                    double UserInput1 = Convert.ToDouble(Console.ReadLine());

                    if (UserInput1 == 0)
                    {
                        Console.WriteLine("Введите вес товара: ");
                        double UserInputWeight = Convert.ToDouble(Console.ReadLine());
                        ProductWeight.Add(UserInputWeight);
                    }

                    Console.Clear();
                }
                else if (UserInput == "l")
                {
                    Console.Clear();

                    for (var i = 0; i < productName.Count; i++)
                    {
                        Console.WriteLine($"Наименование товара, цена: {productName[i]}, {ProductPrice[i]}");
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Вы ввели что-то неверно, возникла данная ошибка: {ex.Message}");
            }
        }
    }
}
