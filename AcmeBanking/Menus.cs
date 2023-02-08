using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking
{
    public class Menus
    {
        public static void MainMenu()
        {
            Display.DisplayMessage("Welcome to Acme Banking Solutions.");
            Display.DisplayPrompt("Does the customer currently have an account with us? \n1. Yes \n2. No\n\n");

            switch(InputObtainer.ObtainMenuSelection(2))
            {
                case 1: { ExistingCustomersMenu(); break; }
                case 2: { AccountCreationMenu(); break; }
            }
        }

        private static void ExistingCustomersMenu()
        {
            Display.DisplayPrompt("Would the customer like to access an existing account or open a new account? \n1. Access existing account \n2. Open new account\n\n");

            switch(InputObtainer.ObtainMenuSelection(2))
            {
                case 1: { ExistingAccountsMenu(); break; }
                case 2: { AccountCreationMenu(); break; }
            }

        }

        private static void AccountCreationMenu()
        {
            Display.DisplayPrompt("What type of the account would the customer like to create? \n1. Personal account \n2. Business account \n3. ISA account\n\n");

            switch (InputObtainer.ObtainMenuSelection(3))
            {
                case 1: { break; }
                case 2: { break; }
                case 3: { break; }
            }

        }

        private static void ExistingAccountsMenu()
        {
            Display.DisplayPrompt("Enter customer account number: ");
        }

        
    }
}
