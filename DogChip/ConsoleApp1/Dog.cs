using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string MyProperty { get; set; }

        public string Race {get; set; }

        public string Color { get; set; }

        public Chip DogChip { get; set; }

        public void AddChip(string owner,string adress)
        {
            DogChip = new Chip(owner,adress);
        }

        public static void IdentifyDog(Dog dog)
        {
            if (dog.DogChip == null)
            {
                Console.WriteLine("There is no chip in this dog");
            }
            else
            {
                Console.WriteLine($"Owner is {dog.DogChip.Owner}");
                Console.WriteLine($"Owner adress is {dog.DogChip.Adress}");
                Console.WriteLine($"ID is {dog.DogChip.ID}");

            }
        }

        public class Chip
        {
            public int ID { get; set; }

            public string Owner { get; set; }

            public string Adress { get; set; }

            public Chip(string owner,string adress)
            {
                Random random = new Random();
                ID = random.Next(1000, 9999);
                Owner = owner;
                Adress = adress;
            }
        }
    }
}
