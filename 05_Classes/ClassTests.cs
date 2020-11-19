using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();

            greeter.SayHello("Aaron");
            string greeting = greeter.GetRandomGreeting();
            greeting = "Random greeting: " + greeting;
            greeter.SaySomething(greeting);

            greeter.SaySomething(greeter.GetRandomGreeting());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Calculator calculator = new Calculator();

            int thirtyTwoHopefully = calculator.Power(2, 5);
            Console.WriteLine(thirtyTwoHopefully);

        }

        [TestMethod]
        public void Subtracting()
        {
            Calculator calculator = new Calculator();

            int subtraction = calculator.Subtract(25, 10);
            Console.WriteLine(subtraction);
        }

        [TestMethod]
        public void Multiply()
        {
            Calculator calculator = new Calculator();

            double multiply = calculator.Multiply(5, 2);
            Console.WriteLine(multiply);
        }

        [TestMethod]
        public void Divide()
        {
            Calculator calculator = new Calculator();

            decimal divide = calculator.Divide(54, 27);
            Console.WriteLine(divide);
        }

        [TestMethod]
        public void VehiceTest()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "blah";
            vehicle.SetModel("blahblah 2.0");

            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.GetModel());

            vehicle.TurnOn();
            vehicle.TurnOn();
            vehicle.TurnOff();
        }

        [TestMethod]
        public void Challenges()
        {
            foreach (char letter in "Supercalifgragilisticexpialidocious")
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void LoopChallenge()
        {
            string word = "Supercalifgragilisticexpialidocious";
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine('i');
                }
                else if (letter == 'l')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
            Console.WriteLine(word.Length);
        }

        [TestMethod]
        public void PersonTest()
        {
            Person carl = new Person("Carl", "Goss", new DateTime(1992, 5, 1));
            Vehicle car = new Vehicle(VehicleType.Car, "Mazda6");
            carl.Transport = car;

            Console.WriteLine(carl.FullName);
            Console.WriteLine(carl.Age);
            Console.WriteLine(carl.Transport.TypeOfVehicle);
        }

        [TestMethod]
        public void UserTest()
        {
            DateTime birthdate = new DateTime(1992, 5, 1);
            User user = new User(1, "Carl", "Goss", birthdate);

            Console.WriteLine(user.GetAgeInYears);
        }
    }
}
