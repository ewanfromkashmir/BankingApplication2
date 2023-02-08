using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.Interfaces
{
    internal interface IAccount
    {
        public string AccountNumber { get; set; }
        public string SortCode { get; set; }
        public float Balance { get; set; }
        public float OverdraftAmount { get; set; }

        void DisplayBalance();
        void Deposit(float amount);
        void Withdraw(float amount);
        void DisplayAccountMenu();
    }
}
