using System;

namespace SimpleATM
{
    public class ATM
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new Account(1000);
                Console.WriteLine("Hello, choose operation:\n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");

                while (true)
                {
                    var userInput = decimal.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            {
                                account.ShowMoney += Display;
                                account.AccountBalance();
                                Console.WriteLine("Choose next operation: \n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");
                            }
                            break;
                        case 2:
                            {
                                account.ShowMoney += Display;
                                account.Refill();
                                Console.WriteLine("Choose next operation: \n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");
                            }
                            break;
                        case 3:
                            {
                                account.ShowMoney += Display;
                                account.CashWithdrawall();
                                Console.WriteLine("Choose next operation: \n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");
                            }
                            break;
                        case 4:
                            {
                                account.ShowMoney += Display;
                                account.Donation();
                                Console.WriteLine("Choose next operation: \n1.Account balance\n2.Reffil\n3.Cash withdrawal\n4.Donation");
                            }
                            break;
                        default:
                            {
                                throw new ArgumentException();
                            }
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
