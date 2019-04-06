using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Trainer : User
    {
        public Trainer(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Trainer;
        }
        public Trainer() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }

        static void ShowGrades(ref Student currentUser)
        {
            Console.WriteLine($"Grades of Student: {currentUser.FirstName} {currentUser.LastName}");
            foreach (var item in currentUser.Grades)
            {
                Console.WriteLine($"{item.Key.SubjectName} : {item.Value}");
            }
        }
    }
}
