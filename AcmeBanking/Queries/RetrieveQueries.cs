using AcmeBanking.Accounts;
using AcmeBanking.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.Queries
{
    static class RetrieveQueries
    {
        public static BaseAccount RetrieveAccount(string accountNumber)
        {
            string type = "";

            switch(type)
            {
                case "personal": { break; }
                case "business": { break; }
                case "isa": { break; }
            }

        }

        public static string[] RetrieveListOfAccounts(string firstName, string lastName, string dateOfBirth)
        {

        }

    }
}
