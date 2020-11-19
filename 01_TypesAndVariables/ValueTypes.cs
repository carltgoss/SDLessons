using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool IsDeclared;

            IsDeclared = true;
            Console.WriteLine("\\");
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = -127;
            short shortExample = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longExample = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            Console.WriteLine(1.454574747774574745747474738284825825853f);

            double doubleExample = 1.7383674457457472752756365265d;
            Console.WriteLine(doubleExample);

            decimal decimalExample = 1.564373657485657846385755783659856565827895m;
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Croissant, Cookies, Scone, Danish, Baguette };

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1992, 5, 1);
            Console.WriteLine(birthday);

            TimeSpan age = today - birthday;
        }
    }

}
