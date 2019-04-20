using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceParts
    {
        public bool ShowProductsByPart(List<Part> parts, List<Part> cartP ,List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.Clear();
                int counter = 1;
                foreach (var part in parts)
                {
                    Console.WriteLine($"{counter}. Name: {part.Name}");
                    counter++;
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
                    cartP.Add(parts[input - 1]);
                    Part boughtPart = parts[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Name} is added to your cart!");
                    var nesto = UiService.NextAction(ShowProductsByPart, parts, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByPriceOfPart(List<Part> parts, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                int min = 0;
                int max = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Lowest is 8 dollars, Highest is 1500. Enter between these numbers:");
                    Console.WriteLine("Enter minimum price of Part:");
                    min = int.Parse(Console.ReadLine());
                    if (min < 8 || min > 1500)
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
                    if (max < min || max > 1500)
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
                var itemList = parts.Where(x => x.Price > min && x.Price < max).ToList();

                if (itemList.Count == 0)
                {
                    Console.WriteLine("There are no parts in that range!Please try again.Press any key.");
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                int counter = 1;
                foreach (var item in itemList)
                {
                    Console.WriteLine($"{counter}. Name: {item.Name}, Price: {item.Price}");
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
                    cartP.Add(itemList[input - 1]);
                    Part boughtPart = itemList[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Name} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByPriceOfPart, parts, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }

        public bool ShowByTypeOfPart(List<Part> parts, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the type of part");
                Console.WriteLine("1.CPU");
                Console.WriteLine("2.CpuCooler");
                Console.WriteLine("3.Gpu");
                Console.WriteLine("4.GpuCooler");
                Console.WriteLine("5.Case");
                Console.WriteLine("6.PowerSuply");
                Console.WriteLine("7.MotherBoard");
                Console.WriteLine("8.ConnectionCable");
                Console.WriteLine("9.PowerCable");
                Console.WriteLine("10.SSD");
                Console.WriteLine("11.HDD");
                Console.WriteLine("12.RAM");
                Console.WriteLine("13.Monitor");
                Console.WriteLine("14.Mouse");
                Console.WriteLine("15.Keyboard");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 15)
                {
                    Console.WriteLine("Enter valid number of product. Press any key and try again!");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    var nesto = ShowTypes(input, parts, cartP, cartM , cartC);
                    return nesto;
                }
            }
        }

        public bool ShowTypes(int number, List<Part> parts, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
        {
            Console.Clear();
            int counter = 1;
            foreach (var item in parts)
            {
                if ((int)item.Type == number)
                {
                    Console.WriteLine($"{counter}. Name: {item.Name}, Type: {item.Type}");
                    counter++;
                }
            }
            var nesto = BuyProduct(counter, number, parts, cartP, cartM, cartC);
            return nesto;
        }

        public bool BuyProduct(int counter, int number, List<Part> parts, List<Part> cartP, List<Module> cartM, List<Configuration> cartC)
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
                    List<Part> selectedParts = new List<Part>();
                    foreach (var item in parts)
                    {
                        if ((int)item.Type == number)
                        {
                            selectedParts.Add(item);
                        }
                    }
                    cartP.Add(selectedParts[input - 1]);
                    Part boughtPart = selectedParts[input - 1];
                    Console.WriteLine($"Product of type: {boughtPart.Type} {boughtPart.Name} is added to your cart!");
                    var nesto = UiService.NextAction(ShowByTypeOfPart, parts, cartP, cartM, cartC);
                    return nesto;
                }
            }
        }
    }
}
