using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFrom1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one number from 1 to 3!");
            var numberInput = Console.ReadLine();
            bool parseResult = int.TryParse(numberInput, out int NumberValue);

            if(!parseResult)
            {
                Console.WriteLine($"You entered '{numberInput}' which is not a valid integer");
                return;
            }

            switch(NumberValue)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;

                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;

                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;


                default:
                    Console.WriteLine($"{NumberValue} is wrong number");
                    break;


            }
        }
    }
}
