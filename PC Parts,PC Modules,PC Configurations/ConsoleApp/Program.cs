using Services;
using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = Db.Parts;
            var modules = Db.Modules;
            var configurations = Db.Configurations;
            ServiceParts serviceParts = new ServiceParts();
            ServiceModules serviceModules = new ServiceModules();
            ServiceConfigurations serviceConfiguration = new ServiceConfigurations();
            List<Part> cartP = new List<Part>();
            List<Module> cartM = new List<Module>();
            List<Configuration> cartC = new List<Configuration>();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome!");
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Part");
                Console.WriteLine("2. Module");
                Console.WriteLine("3. Configuration");
                int input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        UiService.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if(input1 == 1)
                        {
                            var nesto = serviceParts.ShowProductsByPart(parts,cartP,cartM,cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if(input1 == 2)
                        {
                            var nesto = serviceParts.ShowByPriceOfPart(parts, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if(input1 == 3)
                        {
                            var nesto = serviceParts.ShowByTypeOfPart(parts, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter valid action! Press any key.");
                            Console.ReadLine();
                            continue;
                        }
                    }
                }
                else if(input == 2)
                {
                    while (true)
                    {
                        UiService.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if (input1 == 1)
                        {
                            var nesto = serviceModules.ShowProductsByModules(modules, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if (input1 == 2)
                        {
                            var nesto = serviceModules.ShowByPriceOfModules(modules, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if (input1 == 3)
                        {
                            var nesto = serviceModules.ShowByTypeModules(modules, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter valid action! Press any key.");
                            Console.ReadLine();
                            continue;
                        }
                    }
                }
                else if(input == 3)
                {
                    while (true)
                    {
                        UiService.ChooseAction();
                        int input1 = int.Parse(Console.ReadLine());
                        if (input1 == 1)
                        {
                            var nesto = serviceConfiguration.ShowProductsByConfigurations(configurations, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if (input1 == 2)
                        {
                            var nesto = serviceConfiguration.ShowByPriceOfConfigurations(configurations, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else if (input1 == 3)
                        {
                            var nesto = serviceConfiguration.ShowByPriceOfConfigurations(configurations, cartP, cartM, cartC);
                            if (!nesto)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter valid action! Press any key.");
                            Console.ReadLine();
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid action!");
                    Console.WriteLine("Press any key to try again!");
                    Console.ReadLine();
                    continue;
                }
            }

        }
    }
}
