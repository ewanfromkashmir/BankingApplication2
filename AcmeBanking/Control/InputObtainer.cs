using AcmeBanking.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcmeBanking.Control
{
    public class InputObtainer
    {
        private static string ObtainUserInput()
        {
            string? input = Console.ReadLine();

            while (input == null)
            {
                Display.DisplayWarning("No input. Please try again.");
                input = Console.ReadLine();
            }

            return input;
        }

        public static double ObtainInputDouble()
        {
            double inputDouble;

            while (!double.TryParse(ObtainUserInput(), out inputDouble))
            {
                Display.DisplayWarning("Unrecognised input. Please try again.");
            }

            return inputDouble;
        }

        public static double ObtainInputDouble(double minimum, double maximum)
        {
            double inputDouble = ObtainInputDouble();

            while (inputDouble < minimum || inputDouble > maximum)
            {
                Display.DisplayWarning("Input range exceeded. Please try again.");
                inputDouble = ObtainInputDouble();
            }

            return inputDouble;
        }

        public static int ObtainInputInteger()
        {
            int inputInteger;

            while (!int.TryParse(ObtainUserInput(), out inputInteger))
            {
                Display.DisplayWarning("Unrecognised input. Please try again.");
            }

            return inputInteger;
        }

        public static int ObtainInputInteger(int minimum, int maximum)
        {
            int inputInteger = ObtainInputInteger();

            while (inputInteger < minimum || inputInteger > maximum)
            {
                Display.DisplayWarning("Input range exceeded. Please try again.");
                inputInteger = ObtainInputInteger();
            }

            return inputInteger;
        }

        public static string ObtainInputName()
        {
            string name = ObtainUserInput();

            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Display.DisplayWarning("Unsupported input. Please try again.");
                name = ObtainUserInput();
            }

            return name;
        }

        public static int ObtainMenuSelection(int options)
        {
            int menuSelection;

            while (!(int.TryParse(ObtainUserInput(), out menuSelection) && menuSelection > 0 && menuSelection <= options))
            {
                Display.DisplayWarning("Unrecognised input. Please try again.");
            }

            return menuSelection;
        }
    }
}