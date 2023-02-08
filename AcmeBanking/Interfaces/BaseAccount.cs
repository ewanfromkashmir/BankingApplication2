using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.Interfaces
{
    abstract class BaseAccount : IAccount
    {
        public string AccountNumber { get; set; }
        public string SortCode { get; set; } = "02-12-20";
        public float Balance { get; set; } = 0;
        public float OverdraftAmount { get; set; } = 0;

        public BaseAccount(string accountNumber, string sortCode, float balance, float overdraftAmount)
        {
            AccountNumber = accountNumber;
            SortCode = sortCode;
            Balance = balance;
            OverdraftAmount = overdraftAmount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine(Balance);
        }

        public void Deposit(float amount)
        {
            Balance += amount;
        }

        public void Withdraw(float amount)
        {
            Balance -= amount;
        }

        public abstract void DisplayAccountMenu();

    }
}
