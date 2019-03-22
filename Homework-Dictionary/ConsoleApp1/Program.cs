using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Jane", 70324541 },
                {"Emi",  21904232 },
                {"Megi", 75105284 },
                {"Erik", 71863103 },
                {"Rolo", 71432112 }
            };
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            PrintPhone(phoneBook, name);
        }


        public static void PrintPhone(Dictionary<string, long> phoneBook, string name)
        {
            if (!phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
                return;
            }
            Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
        }
    }
}