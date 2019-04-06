using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities

{
    class Admin : User
    {
        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Admin;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }

        static void AddUser(List<User> lista, User user1)
        {
            Console.WriteLine($"Hello {user1.FirstName} {user1.LastName}!");
            Console.WriteLine("What role do you want to add?");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");
            int add = int.Parse(Console.ReadLine());

            if (add == 1)
            {
                User user = EnterInfo(Role.Admin);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Admin!");
            }
            else if (add == 2)
            {
                User user = EnterInfo(Role.Trainer);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Trainer!");
            }
            else if (add == 3)
            {
                User user = EnterInfo(Role.Student);
                lista.Add(user);
                Console.WriteLine("You have successfuly added an Student!");
            }
            else
            {
                throw new Exception("Please enter 1,2 or 3");
            }
            foreach (User user in lista)
            {
                user.PrintInfo();
            }
        }

        static void RemoveUser(List<User> lista, User user1)
        {
            Console.WriteLine($"Hello {user1.FirstName} {user1.LastName}!");
            Console.WriteLine("Which user do you want to remove?");
            User selectedUser = null;

            foreach (User user in lista)
            {
                if (user == user1)
                {
                    continue;
                }
                user.PrintInfo();
            }

            Console.WriteLine("Enter First Name of User:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of User:");
            string lName = Console.ReadLine();

            if (fName == user1.FirstName && lName == user1.LastName)
            {
                throw new Exception("You cannot remove yourself!");
            }
            else
            {
                foreach (User user in lista)
                {
                    if (user.FirstName == fName)
                    {
                        if (user.LastName == lName)
                        {
                            selectedUser = user;
                        }
                    }
                }
            }

            if (selectedUser == null)
            {
                throw new Exception("There is not such a user!");
            }
            else
            {
                Console.WriteLine($"You have deleted {selectedUser.FirstName} {selectedUser.LastName}!");
                lista.Remove(selectedUser);
                foreach (User user in lista)
                {
                    user.PrintInfo();
                }
            }


        }
    }
}
