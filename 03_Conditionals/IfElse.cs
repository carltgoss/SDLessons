using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 35;

            if (age > 100)
            {
                Console.WriteLine("You are a super adult. Congrats!");
            } else if (age > 18)
            {
                Console.WriteLine("You are a regular adult. GJ!");
            } else
            {
                Console.WriteLine("You dumb kid, go away.");
            }

        }
    }
}
