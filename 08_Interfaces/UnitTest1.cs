using System;
using System.Collections.Generic;
using _08_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Orange orange = new Orange(true);
            Orange unpeeledOrange = new Orange(false);

            Console.WriteLine(orange.IsPeeled);
            Console.WriteLine(unpeeledOrange.IsPeeled);

            Console.WriteLine(orange.Peel());
            Console.WriteLine(unpeeledOrange.Peel());

            Banana banana = new Banana();

            List<IFruit> fruitBasket = new List<IFruit>();
            fruitBasket.Add(banana);
            fruitBasket.Add(orange);
        }
    }
}
