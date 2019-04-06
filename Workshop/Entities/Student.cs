using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject,int> Grades { get; set; }

        public Student(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Student;
            CurrentSubject = new Subject();
            Grades = new Dictionary<Subject, int>();
        }

        public Student() { }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Role}");
        }

        static void EnrolToSubject(ref Student currentUser, string nameOfSub, List<Subject> subjects)
        {
            bool flag = false;
            foreach (Subject subject in subjects)
            {
                if (subject.SubjectName == nameOfSub)
                {
                    subject.Listeners++;
                    currentUser.CurrentSubject = subject;
                    flag = true;
                    Console.WriteLine($"You have successfuly enroled to {subject.SubjectName}");
                }
            }
            if (!flag)
            {
                throw new Exception("Not such a subject!");
            }
        }
    }

}
