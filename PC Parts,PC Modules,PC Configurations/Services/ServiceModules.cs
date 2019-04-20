using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceModules
    {
        public bool ShowProductsByModules(List<Module> modules, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.Clear();
                int counter = 1;
                foreach (var module in modules)
                {
                    Console.WriteLine($"{counter}. Type: {module.Type}");
                    counter++;
                    Console.WriteLine();
                    foreach (var item in module.Parts)
                    {
                        Console.WriteLine($"Part: {item.Name}");
                    }
                    Console.WriteLine("-----------------------------");
                }
                Console.WriteLine("Choose product to buy:");
                int input = int.Parse(Console.ReadLine());

                if (input < 1 || input > counter)
                {
                    Console.WriteLine("Enter valid number. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    cartM.Add(modules[input - 1]);
                    Module boughtPart = modules[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} is added to your cart!");
                    var nesto = UiService.NextAction(ShowProductsByModules, modules, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByPriceOfModules(List<Module> modules, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 100 dollars, Highest is 840. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Module:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 100 || min > 840)
                    {
                        Console.WriteLine("Enter valid number.Press any key.");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter maximum price of Part:");
                    max = int.Parse(Console.ReadLine());
                    if (max < min || max > 840)
                    {
                        Console.WriteLine("Enter valid number.Press any key.");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                var itemList = modules.Where(x => x.Price > min && x.Price < max).ToList();
                if(itemList.Count == 0)
                {
                    Console.WriteLine("There are no parts in that range! Please try again.Press any key.");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                int counter = 1;
                foreach (var item in itemList)
                {
                    Console.WriteLine($"{counter}. Name: {item.Type}, Price: {item.Price}");
                    counter++;
                }

                Console.WriteLine("Choose Product to buy:");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > counter)
                {
                    Console.WriteLine("Enter valid number. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    cartM.Add(itemList[input - 1]);
                    Module boughtPart = itemList[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByPriceOfModules, modules, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByTypeModules(List<Module> modules, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.Processing");
                Console.WriteLine("2.Graphics");
                Console.WriteLine("3.Casing");
                Console.WriteLine("4.MainBoard");
                Console.WriteLine("5.Memory");
                Console.WriteLine("6.Other");

                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 15)
                {
                    Console.WriteLine("Enter valid number of product. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    var nesto = ShowTypes(input, modules, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowTypes(int number, List<Module> modules, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            Console.Clear();
            int counter = 1;
            foreach (var item in modules)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"{counter}. Type: {item.Type} Price: {item.Price}");
                    counter++;
                }
            }
            var nesto = BuyProduct(counter, number, modules, cartP, cartM, cartC);
            return nesto;
        }

        public bool BuyProduct(int counter, int number, List<Module> modules, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.WriteLine("Choose Part to Buy:");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > counter)
                {
                    Console.WriteLine("Please enter valid number of product. Please press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    List<Module> selectedParts = new List<Module>();
                    foreach (var item in modules)
                    {
                        if ((int)item.Type == number)
                        {
                            selectedParts.Add(item);
                        }
                    }
                    cartM.Add(selectedParts[input - 1]);
                    Module boughtPart = selectedParts[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByTypeModules, modules, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }
    }
}
