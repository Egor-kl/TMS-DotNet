using System;
using System.Collections.Generic;

namespace SimpleATM
{
    /// <summary>
    /// Счет.
    /// </summary>
    public class Account
    {
        private readonly Dictionary<int, string> DonationPlaces = new Dictionary<int, string>
        {
            { 1, "Medicine" },
            { 2, "Education" }
        };

        private readonly decimal _money;

        public delegate void InputHandler(string str);
        public event InputHandler ShowMoney;

        /// <summary>
        /// Счет.
        /// </summary>
        /// <param name="money">Кол-во денег.</param>
        public Account(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException();
            }

            _money = money;
        }

        /// <summary>
        /// Проверка баланса.
        /// </summary>
        public void AccountBalance() => ShowMoney?.Invoke($"Account balance: {_money}");

        /// <summary>
        /// Снятие со счёта.
        /// </summary>
        public void CashWithdrawall()
        {
            Console.WriteLine($"On your account {_money} y.e.\nHow much money do you want to withdraw from the account?");
            
            decimal userInputMoney = decimal.Parse(Console.ReadLine());
            if (_money < userInputMoney)
            {
                throw new ArgumentException();
            }

            decimal sum = _money - userInputMoney;
            ShowMoney?.Invoke($"Now in your account {sum} y.e.");
        }

        /// <summary>
        /// Пополнение счёта.
        /// </summary>
        public void Refill()
        {
            Console.WriteLine("How much money do you want to put into your account?");

            decimal userInputMoney = decimal.Parse(Console.ReadLine());
            decimal sum = _money + userInputMoney;

            ShowMoney?.Invoke($"Now in your account {sum} y.e.");
        }

        /// <summary>
        /// Пожертвования.
        /// </summary>
        public void Donation()
        {
            Console.WriteLine("How much money do you want to donate?");

            decimal userInputMoney = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Where do you want to donate your money?");

            foreach (var item in DonationPlaces)
            {
                Console.WriteLine(item);
            }

            var userInput = int.Parse(Console.ReadLine());
            decimal sum = _money - userInputMoney;
            switch (userInput)
            {
                case 1:
                    ShowMoney?.Invoke($"Thank you for donation in medicine, now in your account {sum} y.e.");
                    break;
                case 2:
                    ShowMoney?.Invoke($"Thank you for donation in education, now in your account {sum} y.e.");
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
