using System;
using System.Collections.Generic;
using _07_Inheritence.Animals;
using _07_Inheritence.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritence
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTest()
        {
            Person me = new Person();
            me.FirstName = "Carl";
            me.LastName = "Goss";
            Console.WriteLine(me.Name);

            Employee dwight = new Employee(12345);
            dwight.FirstName = "Dwight";
            dwight.LastName = "Shrute";
            Console.WriteLine(dwight.Name);
            Console.WriteLine(dwight.EmployeeNumber);

            SalaryEmployee jim = new SalaryEmployee(12333, 60000);
            jim.FirstName = "Jim";
            Console.WriteLine(jim.FirstName);
            Console.WriteLine(jim.EmployeeNumber);
            Console.WriteLine(jim.Salary);

            List<Employee> ListOfEmployees = new List<Employee>();
            ListOfEmployees.Add(jim);
            ListOfEmployees.Add(dwight);
        }

        [TestMethod]
        public void AnimalTest()
        {
            //Animal animal = new Animal();
            Sloth sloth = new Sloth();
            Console.WriteLine(sloth.IsSlow);
            sloth.Move();
            sloth.SayFurColor();
        }

        [TestMethod]
        public void CheetahTest()
        {
            Cheetah cheetah = new Cheetah();
            Console.WriteLine(cheetah.IsFast);
        }
    }
}
