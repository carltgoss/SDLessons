using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
             ui.Run();

            

            
        }

        private void FizzBuzz(int limit)
        {
            for (int i = 0; i<=limit; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("FizzBuzz");

                }else if (i%5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("Buzz");

                }else if (i%3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(i);
            }
        }
    }
}
