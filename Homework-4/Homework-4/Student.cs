using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student()
        {

        }

        public Student(string name,int age,string academy,string group)
        {
            Name = name;
            Age = age;
            Academy = academy;
            Group = group;
        }
    }
}
