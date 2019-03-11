using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string firstInput, secondInput, thirdInput;

                while (true)
                {
                    Console.WriteLine("Enter first student: ");
                     firstInput = Console.ReadLine();
                    bool result = int.TryParse(firstInput, out int first);
                    if(!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter second student: ");
                    secondInput = Console.ReadLine();
                    bool result = int.TryParse(secondInput, out int second);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter third student: ");
                    thirdInput = Console.ReadLine();
                    bool result = int.TryParse(thirdInput, out int third);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }

                string[] array = { firstInput, secondInput, thirdInput };
                int length = 0;
                string name = "";
                foreach (string input in array)
                {
                    if(input.Length > length)
                    {
                        length = input.Length;
                        name = input;
                    }
                }

                Console.WriteLine($"The longest name is {name}");
                Console.ReadLine();
               
                



            }
        }
    }
}
