using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        private object firstList;

        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 28;
            string name = "Carl";
            bool isForty = age == 40;
            bool isName = name == "Carl";
            Console.WriteLine("Am I exactly 40? " + isForty + " Is my name Carl? " + isName);

            bool isNotEighteen = age != 18;

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isOVerOneHUndred = age > 100;

            bool trueValue = true;
            bool falseValue = false;

            bool andValue = trueValue && falseValue;
            bool orValue = trueValue || falseValue;

            int remainder = 10 % 3;
            Console.WriteLine(remainder);


        }
    }
}
