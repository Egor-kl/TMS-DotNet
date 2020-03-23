using System;

namespace calculator
{
    class Program
    {
        static string result;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " ,it's my calculator");
            Operation();
        }
        public static void Operation()
        {
            Console.WriteLine("Please, enter your first number: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter your second number: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select your operations: '+', '-', '/', '*' ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = Convert.ToString(Summ(numberOne, numberTwo));
                    break;
                case "-":
                    result = Convert.ToString(Difference(numberOne, numberTwo));
                    break;
                case "/":
                    result = Convert.ToString(Division(numberOne, numberTwo));
                    break;
                case "*":
                    result = Convert.ToString(Product(numberOne, numberTwo));
                    break;
            }
            Console.WriteLine("Result: "+ result);
        }
        static double Summ(double numberOne, double numberTwo) => numberOne + numberTwo;
        static double Difference(double numberOne, double numberTwo) => numberOne - numberTwo;
        static double Division(double numberOne, double numberTwo)
        {
            if (numberTwo == 0)
               Console.WriteLine("Division on zero");
            return numberOne / numberTwo;
        }
        static double Product(double numberOne, double numberTwo) => numberOne * numberTwo;
    }
}