using AcmeBanking.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.Queries
{
    static class CreateQueries
    {
        public static bool CreateAccount(BaseAccount account)
        {
            string type = "";

            switch(type)
            {
                case "personal": { break; }
                case "business": { break; }
                case "isa": { break; }
            }

            return true;
        }

        public static bool CreateUser(string firstName, string lastName, string dateOfBirth)
        {
            return true;
        }

        public static bool CreateBusiness(string businessName)
        {
            return true;
        }
    }
}
