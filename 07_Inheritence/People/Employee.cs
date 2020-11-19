using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.People
{
    //               Inheritance
    public class Employee : Person
    {
        public int EmployeeNumber { get; }

        public Employee(int number)
        {
            EmployeeNumber = number;
        }
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
        public HourlyEmployee(int number) : base(number)
        {
            Console.WriteLine("Hourly employee hired!");
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int number, decimal salary) : base(number)
        {
            Salary = salary;
        }
    }
}
