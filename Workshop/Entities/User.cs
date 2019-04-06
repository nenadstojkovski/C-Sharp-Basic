using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User() { }

        public User (string firstName,string lastName,string userName,string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = userName;
            Password = password;
            
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public string GetPassword()
        {
            return Password;
        }


        public static User EnterInfo(Role role)
        {
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();
            User user = new User();
            if (role == Role.Admin)
            {
                user = new Admin(fName, lName, userName, passWord);
            }
            else if (role == Role.Student)
            {
                user = new Student(fName, lName, userName, passWord);
            }
            else if (role == Role.Trainer)
            {
                user = new Trainer(fName, lName, userName, passWord);
            }
            return user;
        }

    }
}


