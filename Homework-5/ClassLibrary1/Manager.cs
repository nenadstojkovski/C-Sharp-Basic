using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Role = Role.Manager;
        }

            public void AddBonus (double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }

    }
}
