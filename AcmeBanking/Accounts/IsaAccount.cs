using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeBanking.Interfaces;

namespace AcmeBanking.Accounts
{
    class IsaAccount : BaseAccount, IPaysInterest, ILimitsBalance
    {
        public IsaAccount(string accountNumber, string sortCode, float balance, float overdraftAmount) : base(accountNumber, sortCode, balance, overdraftAmount) { }

        public override void DisplayAccountMenu()
        {
            Console.WriteLine("Displaying menu for ISA account.");
        }


    }
}
