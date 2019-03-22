
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Rob", LastName = "Stinson", Salary = 400, Role = Role.Other };
            SalesPerson sale = new SalesPerson("Ted", "Johnson", 1000);
            Manager manager = new Manager("John", "Williams");
            sale.AddSuccessSaleRevenue(2000);
            employee.PrintInfo();
            sale.PrintInfo();
            Console.WriteLine("Employee Salary: " + employee.GetSalary());
            Console.WriteLine("Sales Person Salary: " + sale.GetSalary());
            Console.WriteLine("Manager Salary:" + manager.GetSalary());
            Console.ReadLine();
        }
    }
}
