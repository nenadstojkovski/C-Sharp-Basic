using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dzeki = new Dog();
            dzeki.AddChip("bob", "partizanska");

            Dog berta = new Dog();
            Dog.IdentifyDog(berta);

            Dog.IdentifyDog(dzeki);
            Console.ReadLine();
        }
    }
}
