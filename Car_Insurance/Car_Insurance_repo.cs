using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Insurance
{
    [TestClass]
    public class Car_Insurance_repo
    {
        public string ggMessage(int years)
        {
            Car_Insurance customer = new Car_Insurance("abc123", "Goss", 28, new DateTime(2013, 8, 17));

            if (years >= 5)
            {
                return "Thanks for being a Gold Member!";
            }
            else if(years >= 1)
            {
                return "Thank You";
            }
            else
            {
                return "";
            }
        }
    }
    
    
}
