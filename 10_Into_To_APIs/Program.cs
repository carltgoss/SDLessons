﻿using _10_Into_To_APIs.Models;
using _10_Into_To_APIs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Into_To_APIs
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SwapiService swapiService = new SwapiService();
            MySwapiService swapiService = new MySwapiService();

            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("enter a gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter a homeworld ID");
            int homeworld = Convert.ToInt32(Console.ReadLine());

            Character newCharacter = new Character()
            {
                Name = name,
                Gender = gender,
                Homeworld = homeworld
            };

            Console.Clear();
            Console.WriteLine("\n\nSaving new character...");

            swapiService.PostCharacterAsync(newCharacter).Wait();

            Console.Clear();
            Console.WriteLine("New character created!");

            Console.ReadKey();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter a character Id");
                int id = Int32.Parse(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("\n\nLoading...");

                CharacterWithHomeworld character = swapiService.GetCharacterWithHomeworldAsync(1).Result;

                Console.Clear();
                Console.WriteLine(character.Name);
                Console.WriteLine("");
                Console.WriteLine(character.Homeworld.Name);
                // Console.WriteLine(luke.Hair_Color);
                Console.ReadLine();
            }

        }
    }
}
