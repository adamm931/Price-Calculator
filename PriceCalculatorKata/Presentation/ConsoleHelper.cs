using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Presentation
{
    public class ConsoleHelper
    {
        public static void DisplayResults(string content, string title)
        {
            WriteTitle(title);
            WriteContent(content);
            WriteFooter();
        }

        private static void WriteContent(string content)
        {
            Console.ResetColor();
            Console.WriteLine(content);
        }

        private static void WriteFooter()
        {
            Console.Write(new string('-', Console.WindowWidth));
            Console.Write(new string('-', Console.WindowWidth));
        }

        private static void WriteTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{title}.");
            Console.WriteLine();
        }
    }
}
