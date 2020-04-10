using System;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new Account(1000);
                Console.WriteLine("Hello, choose operation:\n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");

                // UNDONE: do-while
                while (true)
                {
                    // UNDONE: TryParse and some message
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            {
                                account.ShowMoney += Display;
                                account.AccountBalance();
                            }
                            break;

                        // UNDONE: fix it
                        case "2":
                            account.ShowMoney += Display;
                            account.Refill();
                            break;
                        case "3":
                            account.ShowMoney += Display;
                            account.CashWithdrawall();
                            break;
                        case "4":
                            account.ShowMoney += Display;
                            account.Donation();
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
