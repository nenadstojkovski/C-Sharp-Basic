using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SalesPerson : Employee
    {
        public int SuccessSaleRevenue { get; set; }


        public SalesPerson(string first, string last, int revenues)
        {
            FirstName = first;
            LastName = last;
            SuccessSaleRevenue = revenues;
            Salary = 500;
            Role = Role.Sales;
        }

        
        public void AddSuccessSaleRevenue(int successValue)
        {
            SuccessSaleRevenue += successValue;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000 )
            {
                return Salary + 500;
            }

            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }
        }
    }
}