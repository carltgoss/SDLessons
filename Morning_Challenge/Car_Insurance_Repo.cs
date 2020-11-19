using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge
{
    class Car_Insurance_Repo
    {
        Car_Insurance customer = new Car_Insurance("abc123", "Goss", 28, new DateTime(2013, 8, 17));
        public string getMessage(int years)
        {
            
            if (years >= 5)
            {
                return "Thanks for being a Gold Member!";
            }
            else if (years >= 1)
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
