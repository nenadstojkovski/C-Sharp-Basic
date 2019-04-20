using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class UiService
    {
        public static void ChooseAction()
        {
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Show Products");
            Console.WriteLine("2. By Price");
            Console.WriteLine("3. By Type");
        }

        public static bool NextAction<T>(Func<List<T>, List<Part>, List<Module>, List<Configuration>, bool> method, List<T> items, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Continue Shopping");
                Console.WriteLine("2. Choose something else");
                Console.WriteLine("3. See Cart");
                Console.WriteLine("4. Continue to Check Out");

                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 4)
                {
                    Console.WriteLine("Not a valid number.Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }

                if (input == 1)
                {
                    var nesto = method(items, cartP, cartM, cartC);
                    if (!nesto)
                    {
                        return false;
                    }
                    else
                    {
                        method(items, cartP, cartM, cartC);
                    }
                }
                else if (input == 2)
                {
                    return false;
                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Your Cart:");
                    foreach (var item in cartP)
                    {
                        Console.WriteLine($"Name: {item.Name}");
                    }
                    foreach (var item in cartM)
                    {
                        Console.WriteLine($"Name: {item.Type}");
                    }
                    foreach (var item in cartC)
                    {
                        Console.WriteLine($"Name: {item.Title}");
                    }
                    Console.WriteLine();
                }
                else if (input == 4)
                {
                    Console.Clear();
                    double sum = 0;
                    sum += cartP.Sum(x => x.Price);
                    sum += cartM.Sum(x => x.Price);
                    sum += cartC.Sum(x => x.Price);
                    Console.WriteLine($"Price of all products = {sum}");
                }
                else
                {
                    Console.WriteLine("Invalid input.Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
