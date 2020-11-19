using Dad_Joke_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dad_Joke_API
{
    public class ProgramUI
    {
        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.Clear();

                Console.WriteLine("Press 1 for a joke");
                Console.WriteLine("Press 2 to exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        JokeService jokeServices = new JokeService();
                        Jokes joke = jokeServices.GetJokeAsync().Result;


                        Console.WriteLine(joke.Setup);
                        Console.ReadLine();
                        Console.WriteLine(joke.Punchline);
                        Console.ReadLine();
                        break;
                    case "2":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }
    }
}
