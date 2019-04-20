using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class ServiceConfigurations
    {
        public bool ShowProductsByConfigurations(List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                int counter = 1;
                Console.Clear();
                foreach (var configuration in configurations)
                {
                    Console.WriteLine($"{counter}. Configuration Name: {configuration.Title}");
                    counter++;
                    Console.WriteLine();
                    foreach (var module in configuration.Modules)
                    {
                        Console.WriteLine($"Module Name: {module.Type}");
                        foreach (var part in module.Parts)
                        {
                            Console.WriteLine($"Part: {part.Name}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("--------------------------------");
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
                    cartC.Add(configurations[input - 1]);
                    var boughtPart = configurations[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Title} is added to your cart!");
                    var nesto = UiService.NextAction(ShowProductsByConfigurations, configurations, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByPriceOfConfigurations(List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 800 dollars, Highest is 1800. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Part:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 800 || min > 1800)
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
                    if (max < min || max > 1800)
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
                var itemList = configurations.Where(x => x.Price > min && x.Price < max).ToList();

                if (itemList.Count == 0)
                {
                    Console.WriteLine("There are no parts in that range!Please Try again. Press any key!");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                int counter = 1;
                foreach (var item in itemList)
                {
                    Console.WriteLine($"{counter}. Name: {item.Title}, Price: {item.Price}");
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
                    cartC.Add(itemList[input - 1]);
                    Configuration boughtPart = itemList[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByPriceOfConfigurations, configurations, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByTypeOfConfigurations(List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.Standard");
                Console.WriteLine("2.Office");
                Console.WriteLine("3.Gaming");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 15)
                {
                    Console.WriteLine("Enter valid number of product. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    var nesto = ShowTypes(input, configurations, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowTypes(int number, List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            Console.Clear();
            int counter = 1;
            foreach (var item in configurations)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"{counter}. Type: {item.Type} Price: {item.Price}");
                }
            }
            var nesto = BuyProduct(counter, number, configurations, cartP, cartM, cartC);
            return nesto;
        }

        public bool BuyProduct(int counter, int number, List<Configuration> configurations, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
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
                    List<Configuration> selectedParts = new List<Configuration>();
                    foreach (var item in configurations)
                    {
                        if ((int)item.Type == number)
                        {
                            selectedParts.Add(item);
                        }
                    }
                    cartC.Add(selectedParts[input - 1]);
                    Configuration boughtPart = selectedParts[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Title} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByTypeOfConfigurations, configurations, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }
    }
}
