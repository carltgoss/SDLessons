using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        // Method

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "Hello", "Howdy", "Salve", "Hola", "Privet", "Greetings" };
            int randomNumber = randy.Next(0, greetings.Length);
            string greeting = greetings.ElementAt(randomNumber);
            return greeting;
        }
    }
}
