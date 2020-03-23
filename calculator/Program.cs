using System;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            double numberOne;
            double numberTwo;
            string name;
            string operation;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, "+name+" ,it's my calculator");
            Console.WriteLine("Choose your operation: +, -, /, * : ");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Choose your first number: ");
                    numberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose your first number: ");
                    numberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(numberOne + numberTwo);
                    break;

                case "-":
                    Console.WriteLine("Choose your first number: ");
                    numberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose your first number: ");
                    numberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(numberOne - numberTwo);
                    break;
                case "/":
                    Console.WriteLine("Choose your first number: ");
                    numberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose your first number: ");
                    numberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(numberOne + numberTwo);
                    break;
                case "*":
                    Console.WriteLine("Choose your first number: ");
                    numberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose your first number: ");
                    numberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(numberOne * numberTwo);
                    break;
                default:
                    Console.WriteLine("Something was entered incorrectly");
                    break;

            }
            Console.WriteLine("Thank you for using!");
        }
    }
}