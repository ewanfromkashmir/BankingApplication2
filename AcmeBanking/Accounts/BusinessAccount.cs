using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeBanking.Interfaces;

namespace AcmeBanking.Accounts
{
    internal class BusinessAccount : BaseAccount, IPaysAnnualFee
    {
        private string BusinessName { get; set; }

        public BusinessAccount(string accountNumber, string sortCode, float balance, float overdraftAmount, string businessName) : base(accountNumber, sortCode, balance, overdraftAmount)
        {
            BusinessName = businessName;
        }

        public override void DisplayAccountMenu()
        {
            Console.WriteLine("Displaying menu for business account.");
        }
    }
}
