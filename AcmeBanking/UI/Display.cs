using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBanking.UI
{
    public class Display
    {
        public static void DisplayPrompt(string prompt)
        {
            Console.Write($"\n{prompt}");

        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayWarning(string warning)
        {
            Console.WriteLine($"{warning}\n");
        }

        public static void DisplayResult(double result)
        {
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}
