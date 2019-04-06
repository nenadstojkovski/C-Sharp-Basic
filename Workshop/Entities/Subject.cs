using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Subject
    {
        public string SubjectName { get; set; }
        public int Listeners { get; set; }

        public Subject() { }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
           Listeners = 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine(SubjectName);
        }
    }
}
