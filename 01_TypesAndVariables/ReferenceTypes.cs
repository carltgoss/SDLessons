using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Carl";
            string lastName = "Goss";

            string concatenatedFullName = firstName + " " + lastName;

            Console.WriteLine(concatenatedFullName);

            string compositeName = string.Format("my name is {0} {1}", firstName, lastName);
            Console.WriteLine(compositeName);

            string interpolatedName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedName);
        }

        [TestMethod]
        public void Classes()
        {
            Random randy = new Random();
            int randomNumber = randy.Next(1, 11);
            Console.WriteLine(randomNumber);

            int otherRandomNumber = randy.Next(1, 11);
            Console.WriteLine(randomNumber);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello world!";


            string[] stringArray = { "Hello", "world", "why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "hello there"; 
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");

            List<int> listOfInts = new List<int>();
            listOfInts.Add(456);

            int firstInt = listOfInts[0];

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");
            string firstItem = firstInFirstOut.Dequeue();
            string nextItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(nextItem);

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Carl");

            string name = keyAndValue["name"];
            Console.WriteLine(name);

            Dictionary<string, double> importantNumbers = new Dictionary<string, double>();
            importantNumbers.Add("pi", 3.1459265358979);
            importantNumbers.Add("e", 2.57);

        }
    }
}
