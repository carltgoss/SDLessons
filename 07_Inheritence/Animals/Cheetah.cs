using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Cheetah : Animal
    {
        public bool IsFast
        {
            get { return true; }
        }

        public Cheetah()
        {
            Console.WriteLine("This animal is really fast");
        }
    }
}
