using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("     * ");
            Console.WriteLine("    *** ");
            Console.WriteLine("   ***** ");
            Console.WriteLine("  ******* ");
            Console.WriteLine(" ********* ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("    | | ");
            Console.WriteLine("    | | ");
            Console.ForegroundColor = oldColor;
            Console.ReadLine();


        }
    }
}
